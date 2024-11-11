using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScanAndSniff
{
    public partial class NetworkSniffer : Form
    {
        public NetworkSniffer()
        {
            InitializeComponent();
            InitializeListView();
            LoadNetworkInterfaces();
            btnTextToHex.Enabled = false;
            btnStop.Enabled = false;
        }

        private CancellationTokenSource _cancellationTokenSource;
        private int packetNumber;
        private List<IPPacket> packetBuffer = new List<IPPacket>();
        public class IPPacket
        {
            public string Protocol { get; private set; }
            public IPAddress SourceAddress { get; private set; }
            public int SourcePort { get; private set; }
            public IPAddress DestinationAddress { get; private set; }
            public int DestinationPort { get; private set; }
            public int TotalLength { get; private set; }
            public byte[] Data { get; private set; }
            public int MessageLength { get; private set; }
            public int DifferentiatedServices { get; private set; }
            public int Id { get; private set; }
            public int FragmentFlags { get; private set; }
            public int FragmentOffset { get; private set; }
            public int TimeToLive { get; private set; }
            public int HeaderLength { get; private set; }
            public int Version { get; private set; }
            public int Checksum { get; private set; }

            public IPPacket(byte[] buffer, int size)
            {
                // Phiên bản IP (IPv4)
                Version = buffer[0] >> 4;

                // Độ dài của header IP
                HeaderLength = (buffer[0] & 0x0F) * 4;

                // Differentiated Services (Type of Service)
                DifferentiatedServices = buffer[1];

                // Tổng độ dài của gói tin
                TotalLength = (buffer[2] << 8) + buffer[3];

                // Identification (Id)
                Id = (buffer[4] << 8) + buffer[5];

                // Flags và Fragment Offset
                FragmentFlags = (buffer[6] >> 5);
                FragmentOffset = ((buffer[6] & 0x1F) << 8) + buffer[7];

                // Time To Live (TTL)
                TimeToLive = buffer[8];

                // Giao thức (Protocol)
                Protocol = (buffer[9] == 6) ? "TCP" : (buffer[9] == 17) ? "UDP" : "Other";

                // Checksum
                Checksum = (buffer[10] << 8) + buffer[11];

                // Địa chỉ IP nguồn và đích
                SourceAddress = new IPAddress(BitConverter.ToUInt32(buffer, 12));
                DestinationAddress = new IPAddress(BitConverter.ToUInt32(buffer, 16));

                // Tính toán độ dài payload
                MessageLength = size - HeaderLength;
                Data = new byte[MessageLength];
                Array.Copy(buffer, HeaderLength, Data, 0, MessageLength);

                // Lấy cổng nguồn và đích nếu là TCP hoặc UDP
                if (Protocol == "TCP" || Protocol == "UDP")
                {
                    SourcePort = (buffer[HeaderLength] << 8) + buffer[HeaderLength + 1];
                    DestinationPort = (buffer[HeaderLength + 2] << 8) + buffer[HeaderLength + 3];
                }
            }
        }

        public class TCPPacket
        {
            public int SourcePort { get; private set; }
            public int DestinationPort { get; private set; }
            public uint SequenceNumber { get; private set; }
            public uint AcknowledgmentNumber { get; private set; }
            public int Flags { get; private set; }
            public int WindowSize { get; private set; }
            public int Checksum { get; private set; }

            public TCPPacket(byte[] buffer, int offset, int size)
            {
                // Phân tích header TCP
                SourcePort = (buffer[offset] << 8) + buffer[offset + 1];
                DestinationPort = (buffer[offset + 2] << 8) + buffer[offset + 3];
                SequenceNumber = BitConverter.ToUInt32(buffer, offset + 4);
                AcknowledgmentNumber = BitConverter.ToUInt32(buffer, offset + 8);
                Flags = buffer[offset + 13];
                WindowSize = (buffer[offset + 14] << 8) + buffer[offset + 15];
                Checksum = (buffer[offset + 16] << 8) + buffer[offset + 17];
            }
        }

        public class UDPPacket
        {
            public int SourcePort { get; private set; }
            public int DestinationPort { get; private set; }
            public int Length { get; private set; }
            public int Checksum { get; private set; }

            public UDPPacket(byte[] buffer, int offset, int size)
            {
                // Phân tích header UDP
                SourcePort = (buffer[offset] << 8) + buffer[offset + 1];
                DestinationPort = (buffer[offset + 2] << 8) + buffer[offset + 3];
                Length = (buffer[offset + 4] << 8) + buffer[offset + 5];
                Checksum = (buffer[offset + 6] << 8) + buffer[offset + 7];
            }
        }

        public class EthernetPacket
        {
            public byte[] DestinationMac { get; private set; }
            public byte[] SourceMac { get; private set; }
            public ushort EtherType { get; private set; }

            public EthernetPacket(byte[] packetData)
            {
                DestinationMac = new byte[6];
                SourceMac = new byte[6];
                Array.Copy(packetData, 0, DestinationMac, 0, 6);
                Array.Copy(packetData, 6, SourceMac, 0, 6);
                EtherType = BitConverter.ToUInt16(packetData, 12);
            }

            public static string MacAddressToString(byte[] mac) => string.Join(":", Array.ConvertAll(mac, b => b.ToString("X2")));

            public override string ToString() => $"Destination MAC: {MacAddressToString(DestinationMac)}\nSource MAC: {MacAddressToString(SourceMac)}\nEtherType: 0x{EtherType:X4}";
        }

        private void InitializeListView()
        {
            listViewPackets.View = View.Details;
            listViewPackets.FullRowSelect = true;
            listViewPackets.Columns.Add("No.", 70);
            listViewPackets.Columns.Add("Time", 170);
            listViewPackets.Columns.Add("Source", 170);
            listViewPackets.Columns.Add("Source Port", 147);
            listViewPackets.Columns.Add("Destination", 170);
            listViewPackets.Columns.Add("Destination Port", 160);
            listViewPackets.Columns.Add("Protocol", 100);
            listViewPackets.Columns.Add("Packet Size", 150);
        }

        private void LoadNetworkInterfaces()
        {
            foreach (var ni in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                cmbNetworkInterface.Items.Add(ni.Name);
            }
        }

        private void LoadIPAddresses()
        {

            string selectedInterfaceName = cmbNetworkInterface.SelectedItem.ToString();
            NetworkInterface selectedInterface = null;

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.Name == selectedInterfaceName)
                {
                    selectedInterface = netInterface;
                    break;
                }
            }

            if (selectedInterface != null)
            {
                foreach (UnicastIPAddressInformation ipInfo in selectedInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork) // Chỉ lấy địa chỉ IPv4
                    {
                        txtIPAddress.Text = ipInfo.Address.ToString();
                        break;
                    }
                }
            }

        }

        private async Task CapturePackets(CancellationToken cancellationToken)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(txtIPAddress.Text);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 0);

                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP))
                {
                    socket.Bind(localEndPoint);
                    socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, true);

                    byte[] byTrue = new byte[] { 1, 0, 0, 0 };
                    byte[] byOut = new byte[] { 1, 0, 0, 0 };
                    socket.IOControl(IOControlCode.ReceiveAll, byTrue, byOut);

                    byte[] buffer = new byte[65535];

                    while (!cancellationToken.IsCancellationRequested)
                    {
                        int receivedBytes = socket.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                        if (receivedBytes > 0)
                        {
                            var ipPacket = new IPPacket(buffer, receivedBytes);

                            // Lọc giao thức trước khi xử lý
                            string protocolFilter = txtSearch.Text.Trim().ToUpper();
                            if (string.IsNullOrEmpty(protocolFilter) || ipPacket.Protocol.ToUpper() == protocolFilter)
                            {
                                switch (ipPacket.Protocol)
                                {
                                    case "TCP":
                                        var tcpPacket = new TCPPacket(buffer, 20, receivedBytes - 20);
                                        ProcessTcpPacket(ipPacket, tcpPacket);
                                        break;

                                    case "UDP":
                                        var udpPacket = new UDPPacket(buffer, 20, receivedBytes - 20);
                                        ProcessUdpPacket(ipPacket, udpPacket);
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ProcessTcpPacket(IPPacket ipPacket, TCPPacket tcpPacket)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    packetNumber.ToString(),
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    ipPacket.SourceAddress.ToString(),
                    ipPacket.SourcePort.ToString(),
                    ipPacket.DestinationAddress.ToString(),
                    ipPacket.DestinationPort.ToString(),
                    "TCP",
                    ipPacket.TotalLength.ToString()
                });
                listViewPackets.Items.Add(item);
                // Lưu lại thông tin packet dưới dạng Tuple để hiển thị trong TreeView
                item.Tag = Tuple.Create(ipPacket, tcpPacket);
                packetNumber++;
                // Thêm gói tin vào bộ đệm
                packetBuffer.Add(ipPacket);
                // Cuộn đến mục cuối cùng
                listViewPackets.Items[listViewPackets.Items.Count - 1].EnsureVisible();
            });
        }

        private void ProcessUdpPacket(IPPacket ipPacket, UDPPacket udpPacket)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    packetNumber.ToString(),
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    ipPacket.SourceAddress.ToString(),
                    ipPacket.SourcePort.ToString(),
                    ipPacket.DestinationAddress.ToString(),
                    ipPacket.DestinationPort.ToString(),
                    "UDP",
                    ipPacket.TotalLength.ToString()
                });
                listViewPackets.Items.Add(item);
                // Lưu lại thông tin packet dưới dạng Tuple để hiển thị trong TreeView
                item.Tag = Tuple.Create(ipPacket, udpPacket);
                packetNumber++;
                // Thêm gói tin vào bộ đệm
                packetBuffer.Add(ipPacket);
                // Cuộn đến mục cuối cùng
                listViewPackets.Items[listViewPackets.Items.Count - 1].EnsureVisible();
            });
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            listViewPackets.Items.Clear();
            treeViewPacketDetails.Nodes.Clear();
            rtxtHexData.Clear();
            packetNumber = 1;
            _cancellationTokenSource = new CancellationTokenSource();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            await Task.Run(() => CapturePackets(_cancellationTokenSource.Token));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void cmbNetworkInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIPAddresses();
        }

        private void FilterPacketsByProtocol()
        {
            string protocol = txtSearch.Text.Trim().ToUpper();

            // Use Task to run on a background thread
            Task.Run(() =>
            {
                // Filter packets from packetBuffer based on protocol
                var filteredPackets = packetBuffer.Where(ipPacket =>
                    string.IsNullOrEmpty(protocol) || ipPacket.Protocol.ToUpper() == protocol).ToList();

                // Update UI on the main thread
                Invoke(new Action(() =>
                {
                    listViewPackets.Items.Clear(); // Clear previous list

                    int displayPacketNumber = 1; // Initialize "No." index from 1

                    foreach (var ipPacket in filteredPackets)
                    {
                        // Assume ipPacket.Data contains the packet's data buffer
                        byte[] buffer = ipPacket.Data;
                        int offset = 0; // Set offset if needed based on packet data
                        int size = buffer.Length;

                        ListViewItem item;

                        // Check if the protocol is TCP or UDP and parse accordingly
                        if (ipPacket.Protocol == "TCP")
                        {
                            var tcpPacket = new TCPPacket(buffer, offset, size);
                            item = new ListViewItem(new string[]
                            {
                        displayPacketNumber.ToString(),
                        DateTime.Now.ToString("HH:mm:ss.fff"),
                        ipPacket.SourceAddress.ToString(),
                        tcpPacket.SourcePort.ToString(),
                        ipPacket.DestinationAddress.ToString(),
                        tcpPacket.DestinationPort.ToString(),
                        ipPacket.Protocol,
                        ipPacket.TotalLength.ToString()
                            });

                            item.Tag = Tuple.Create(ipPacket, tcpPacket); // Save packet info in Tag
                        }
                        else if (ipPacket.Protocol == "UDP")
                        {
                            var udpPacket = new UDPPacket(buffer, offset, size);
                            item = new ListViewItem(new string[]
                            {
                        displayPacketNumber.ToString(),
                        DateTime.Now.ToString("HH:mm:ss.fff"),
                        ipPacket.SourceAddress.ToString(),
                        udpPacket.SourcePort.ToString(),
                        ipPacket.DestinationAddress.ToString(),
                        udpPacket.DestinationPort.ToString(),
                        ipPacket.Protocol,
                        ipPacket.TotalLength.ToString()
                            });

                            item.Tag = Tuple.Create(ipPacket, udpPacket); // Save packet info in Tag
                        }
                        else
                        {
                            // For non-TCP/UDP packets, display generic info
                            item = new ListViewItem(new string[]
                            {
                        displayPacketNumber.ToString(),
                        DateTime.Now.ToString("HH:mm:ss.fff"),
                        ipPacket.SourceAddress.ToString(),
                        "", // No port for non-TCP/UDP
                        ipPacket.DestinationAddress.ToString(),
                        "", // No port for non-TCP/UDP
                        ipPacket.Protocol,
                        ipPacket.TotalLength.ToString()
                            });

                            item.Tag = ipPacket; // Save packet info in Tag
                        }

                        listViewPackets.Items.Add(item);
                        displayPacketNumber++; // Increment packet number
                    }
                }));
            });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterPacketsByProtocol(); // Gọi phương thức lọc mỗi khi thay đổi nội dung thanh tìm kiếm
        }

        private void DisplayPacketDetails(EthernetPacket ethernetPacket, IPPacket ipPacket, TCPPacket tcpPacket)
        {
            // Tạo node gốc cho packet
            var packetNode = new TreeNode("Packet Details");

            // Frame Node
            var frameNode = new TreeNode("Frame");
            frameNode.Nodes.Add("Length: " + ipPacket.TotalLength + " bytes");
            packetNode.Nodes.Add(frameNode);

            // Ethernet Node
            var ethernetNode = new TreeNode("Ethernet II");
            ethernetNode.Nodes.Add("Source MAC: " + EthernetPacket.MacAddressToString(ethernetPacket.SourceMac));
            ethernetNode.Nodes.Add("Destination MAC: " + EthernetPacket.MacAddressToString(ethernetPacket.DestinationMac));
            packetNode.Nodes.Add(ethernetNode);

            // IP Node
            var ipNode = new TreeNode("Internet Protocol Version 4");
            ipNode.Nodes.Add("Version: " + ipPacket.Version);
            ipNode.Nodes.Add("Header Length: " + ipPacket.HeaderLength);
            ipNode.Nodes.Add("Differentiated Services Field: " + ipPacket.DifferentiatedServices);
            ipNode.Nodes.Add("Total Length: " + ipPacket.TotalLength);
            ipNode.Nodes.Add("Identification: 0x" + ipPacket.Id.ToString("X"));
            ipNode.Nodes.Add("Flags: 0x" + ipPacket.FragmentFlags.ToString("X"));
            ipNode.Nodes.Add("Fragment Offset: " + ipPacket.FragmentOffset);
            ipNode.Nodes.Add("Time to Live: " + ipPacket.TimeToLive);
            ipNode.Nodes.Add("Protocol: " + ipPacket.Protocol);
            ipNode.Nodes.Add("Header Checksum: 0x" + ipPacket.Checksum.ToString("X"));
            ipNode.Nodes.Add("Source Address: " + ipPacket.SourceAddress);
            ipNode.Nodes.Add("Destination Address: " + ipPacket.DestinationAddress);
            packetNode.Nodes.Add(ipNode);

            // TCP Node
            var tcpNode = new TreeNode("Transmission Control Protocol");
            tcpNode.Nodes.Add("Source Port: " + tcpPacket.SourcePort);
            tcpNode.Nodes.Add("Destination Port: " + tcpPacket.DestinationPort);
            tcpNode.Nodes.Add("Sequence Number: " + tcpPacket.SequenceNumber);
            tcpNode.Nodes.Add("Acknowledgment Number: " + tcpPacket.AcknowledgmentNumber);
            int headerLength = (tcpPacket.Flags >> 12) * 4; // Tính độ dài header (tính theo byte)
            tcpNode.Nodes.Add("Header Length: " + headerLength + " bytes");

            // Giải mã các cờ TCP
            var flags = tcpPacket.Flags;
            var flagsNode = new TreeNode("Flags: 0x" + flags.ToString("X"));
            flagsNode.Nodes.Add("Reserved: " + ((flags & 0x800) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Accurate ECN: " + ((flags & 0x400) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Congestion Window Reduced: " + ((flags & 0x80) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("ECN-Echo: " + ((flags & 0x40) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Urgent: " + ((flags & 0x20) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Acknowledgment: " + ((flags & 0x10) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Push: " + ((flags & 0x8) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Reset: " + ((flags & 0x4) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Syn: " + ((flags & 0x2) != 0 ? "Set" : "Not set"));
            flagsNode.Nodes.Add("Fin: " + ((flags & 0x1) != 0 ? "Set" : "Not set"));
            tcpNode.Nodes.Add(flagsNode);

            tcpNode.Nodes.Add("Window Size: " + tcpPacket.WindowSize);
            tcpNode.Nodes.Add("Checksum: 0x" + tcpPacket.Checksum.ToString("X"));
            packetNode.Nodes.Add(tcpNode);

            // Thêm packetNode vào treeView
            treeViewPacketDetails.Nodes.Add(packetNode);
            treeViewPacketDetails.ExpandAll(); // Mở rộng toàn bộ các node
        }
        private void DisplayPacketDetails(EthernetPacket ethernetPacket, IPPacket ipPacket, UDPPacket udpPacket)
        {
            // Tạo node gốc cho packet
            var packetNode = new TreeNode("Packet Details");

            // Frame Node
            var frameNode = new TreeNode("Frame");
            frameNode.Nodes.Add("Length: " + ipPacket.TotalLength + " bytes");
            packetNode.Nodes.Add(frameNode);

            // Ethernet Node
            var ethernetNode = new TreeNode("Ethernet II");
            ethernetNode.Nodes.Add("Source MAC: " + EthernetPacket.MacAddressToString(ethernetPacket.SourceMac));
            ethernetNode.Nodes.Add("Destination MAC: " + EthernetPacket.MacAddressToString(ethernetPacket.DestinationMac));
            packetNode.Nodes.Add(ethernetNode);

            // IP Node
            var ipNode = new TreeNode("Internet Protocol Version 4");
            ipNode.Nodes.Add("Version: " + ipPacket.Version);
            ipNode.Nodes.Add("Header Length: " + ipPacket.HeaderLength);
            ipNode.Nodes.Add("Differentiated Services Field: " + ipPacket.DifferentiatedServices);
            ipNode.Nodes.Add("Total Length: " + ipPacket.TotalLength);
            ipNode.Nodes.Add("Identification: 0x" + ipPacket.Id.ToString("X"));
            ipNode.Nodes.Add("Flags: 0x" + ipPacket.FragmentFlags.ToString("X"));
            ipNode.Nodes.Add("Fragment Offset: " + ipPacket.FragmentOffset);
            ipNode.Nodes.Add("Time to Live: " + ipPacket.TimeToLive);
            ipNode.Nodes.Add("Protocol: " + ipPacket.Protocol);
            ipNode.Nodes.Add("Header Checksum: 0x" + ipPacket.Checksum.ToString("X"));
            ipNode.Nodes.Add("Source Address: " + ipPacket.SourceAddress);
            ipNode.Nodes.Add("Destination Address: " + ipPacket.DestinationAddress);
            packetNode.Nodes.Add(ipNode);

            // UDP Node
            var udpNode = new TreeNode("User Datagram Protocol");
            udpNode.Nodes.Add("Source Port: " + udpPacket.SourcePort);
            udpNode.Nodes.Add("Destination Port: " + udpPacket.DestinationPort);
            udpNode.Nodes.Add("Length: " + udpPacket.Length);
            udpNode.Nodes.Add("Checksum: 0x" + udpPacket.Checksum.ToString("X"));
            packetNode.Nodes.Add(udpNode);

            // Thêm packetNode vào treeView
            treeViewPacketDetails.Nodes.Add(packetNode);
            treeViewPacketDetails.ExpandAll(); // Mở rộng toàn bộ các node
        }

        private string ConvertToHex(byte[] byteArray)
        {
            StringBuilder hex = new StringBuilder(byteArray.Length * 3);
            foreach (byte b in byteArray)
            {
                hex.AppendFormat("{0:X2} ", b);
            }
            return hex.ToString().Trim(); // Loại bỏ dấu cách thừa cuối chuỗi
        }

        private void listViewPackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTextToHex.Enabled = true;
            btnHexToText.Enabled = false;
            if (listViewPackets.SelectedItems.Count > 0)
            {
                treeViewPacketDetails.Nodes.Clear(); // Clear existing nodes

                var selectedItem = listViewPackets.SelectedItems[0];
                var packetData = selectedItem.Tag;

                // Kiểm tra nếu Tag chứa đúng loại dữ liệu để hiển thị chi tiết
                if (packetData is Tuple<IPPacket, TCPPacket> tcpTuple)
                {
                    DisplayPacketDetails(new EthernetPacket(tcpTuple.Item1.Data), tcpTuple.Item1, tcpTuple.Item2);
                    // Hiển thị dữ liệu hex của gói TCP trong txtHexData
                    
                    string temp = ConvertToHex(tcpTuple.Item1.Data);
                    rtxtHexData.Text = HexToText(temp);
                }
                else if (packetData is Tuple<IPPacket, UDPPacket> udpTuple)
                {
                    DisplayPacketDetails(new EthernetPacket(udpTuple.Item1.Data), udpTuple.Item1, udpTuple.Item2);
                    // Hiển thị dữ liệu hex của gói UDP trong txtHexData
                    string temp = ConvertToHex(udpTuple.Item1.Data);
                    rtxtHexData.Text = HexToText(temp);
                }
            }
        }

        //Ham chuyen tu hex sang text
        private string HexToText(string hexData)
        {
            try
            {
                // Chuyển đổi chuỗi hex thành mảng byte
                var bytes = hexData.Split(' ')
                    .Where(x => !string.IsNullOrWhiteSpace(x)) // Bỏ qua các phần tử rỗng hoặc chỉ chứa khoảng trắng
                    .Select(x => Convert.ToByte(x, 16)) // Chuyển từng cặp hex thành byte
                    .ToArray();

                // Thử chuyển mảng byte thành chuỗi văn bản với encoding UTF-8
                string text = Encoding.UTF8.GetString(bytes);

                // Nếu chuỗi văn bản chứa các ký tự điều khiển (hoặc ký tự không hợp lệ), thay thế bằng dấu chấm (.)
                text = string.Join("", text.Select(c => char.IsControl(c) || c < 32 || c > 126 ? '.' : c));

                return text;
            }
            catch
            {
                // Hiển thị thông báo lỗi nếu format hex không hợp lệ
                MessageBox.Show("Invalid hex format.");
                return string.Empty;
            }
        }

        //Ham chuyen tu text sang hex
        private string TextToHex(string text)
        {
            var bytes = Encoding.ASCII.GetBytes(text);
            StringBuilder hex = new StringBuilder(bytes.Length * 3);
            foreach (byte b in bytes)
                hex.AppendFormat("{0:X2} ", b);
            return hex.ToString();
        }

        private void btnTextToHex_Click(object sender, EventArgs e)
        {
            rtxtHexData.Text = TextToHex(rtxtHexData.Text);
            btnHexToText.Enabled = true;
            btnTextToHex.Enabled = false;
        }

        private void btnHexToText_Click(object sender, EventArgs e)
        {
            rtxtHexData.Text = HexToText(rtxtHexData.Text);
            btnTextToHex.Enabled = true;
            btnHexToText.Enabled = false;
        }

        private void saveBtt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                try

                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Write header row (optional)
                        writer.WriteLine("No.,Time,Source,Source Port,Destination,Destination Port,Protocol,Packet Size");

                        // Write captured packet data
                        for (int i = 0; i < listViewPackets.Items.Count; i++)
                        {
                            var item = listViewPackets.Items[i];
                            writer.WriteLine(string.Join(",", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(x => x.Text)));
                        }
                    }

                    MessageBox.Show("Packets saved successfully to " + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving packets: " + ex.Message);
                }
            }
        }
    }
}
