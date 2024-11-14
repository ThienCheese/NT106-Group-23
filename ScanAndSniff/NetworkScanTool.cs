﻿using System;
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

namespace ScanAndSniff
{
    public partial class NetworkScanTool : Form
    {
        private CancellationTokenSource cancelTokenSource;
        private bool isScanning = false;
        private CancellationTokenSource cancelPortScanToken;
        private bool isPortScanning = false;
        private CancellationTokenSource cancellationTokenSource;
        public NetworkScanTool()
        {
            InitializeComponent();
            btnStopScan.Enabled = false; // Vô hiệu hóa nút "Dừng tìm" ban đầu
            btnStopPortScanandListen.Enabled = false; // Vô hiệu hóa nút "Dừng" ban đầu
            LoadNetworkInterfaces();
        }

        public class IPPacket
        {
            public IPAddress SourceAddress { get; private set; }
            public IPAddress DestinationAddress { get; private set; }
            public ProtocolType Protocol { get; private set; }
            public byte[] Data { get; private set; }

            public IPPacket(byte[] packetData, int length)
            {
                // Parse IP header và data
                SourceAddress = new IPAddress(BitConverter.ToUInt32(packetData, 12));
                DestinationAddress = new IPAddress(BitConverter.ToUInt32(packetData, 16));
                Protocol = (ProtocolType)packetData[9];
                Data = new byte[length - 20]; // Bỏ IP header (20 bytes)
                Array.Copy(packetData, 20, Data, 0, Data.Length);
            }
        }

        public class TCPPacket
        {
            public int SourcePort { get; private set; }
            public int DestinationPort { get; private set; }
            public long SequenceNumber { get; private set; }
            public byte[] PayloadData { get; private set; }
            public byte[] Data { get; private set; }

            public TCPPacket(byte[] packetData, int length)
            {
                SourcePort = BitConverter.ToUInt16(new byte[] { packetData[0], packetData[1] }, 0);
                DestinationPort = BitConverter.ToUInt16(new byte[] { packetData[2], packetData[3] }, 0);
                SequenceNumber = BitConverter.ToUInt32(packetData, 4);
                PayloadData = new byte[length - 20]; // Bỏ TCP header (20 bytes)
                Data = packetData;
                Array.Copy(packetData, 20, PayloadData, 0, PayloadData.Length);
            }
        }

        public class UDPPacket
        {
            public int SourcePort { get; private set; }
            public int DestinationPort { get; private set; }
            public byte[] PayloadData { get; private set; }
            public byte[] Data { get; private set; }

            public UDPPacket(byte[] packetData, int length)
            {
                SourcePort = BitConverter.ToUInt16(new byte[] { packetData[0], packetData[1] }, 0);
                DestinationPort = BitConverter.ToUInt16(new byte[] { packetData[2], packetData[3] }, 0);
                PayloadData = new byte[length - 8]; // Bỏ UDP header (8 bytes)
                Data = packetData;
                Array.Copy(packetData, 8, PayloadData, 0, PayloadData.Length);
            }
        }

        //Hàm liệt kê các giao diện mạng
        private void LoadNetworkInterfaces()
        {
            comboBoxNetworkInterfaces.Items.Clear();
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                comboBoxNetworkInterfaces.Items.Add(netInterface.Name);
            }

        }

        // Hàm tính toán địa chỉ bắt đầu và địa chỉ kết thúc từ địa chỉ mạng và subnet mask
        private Tuple<string, string> GetIpRange(string networkAddress, string subnetMask)
        {
            IPAddress networkIp = IPAddress.Parse(networkAddress);
            IPAddress mask = IPAddress.Parse(subnetMask);
            byte[] networkBytes = networkIp.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();

            byte[] startIpBytes = new byte[4];
            byte[] endIpBytes = new byte[4];

            // Địa chỉ bắt đầu
            for (int i = 0; i < 4; i++)
            {
                startIpBytes[i] = (byte)(networkBytes[i] & maskBytes[i]);
                endIpBytes[i] = (byte)(networkBytes[i] | ~maskBytes[i]); // Địa chỉ kết thúc (broadcast)
            }

            string startIp = string.Join(".", startIpBytes);
            string endIp = string.Join(".", endIpBytes);

            return new Tuple<string, string>(startIp, endIp);
        }

        // Hàm chuyển IP sang số nguyên
        private int IPToNumber(string ipAddress)
        {
            var ipBytes = IPAddress.Parse(ipAddress).GetAddressBytes();
            return BitConverter.ToInt32(ipBytes.Reverse().ToArray(), 0);
        }

        // Hàm chuyển số nguyên về địa chỉ IP
        private string NumberToIP(int ipNumber)
        {
            return new IPAddress(BitConverter.GetBytes(ipNumber).Reverse().ToArray()).ToString();
        }

        private async void btnStartScan_Click(object sender, EventArgs e)
        {
            if (comboBoxNetworkInterfaces.SelectedItem != null)
            {
                if (isScanning) return;

                isScanning = true;
                btnStartScan.Enabled = false; // Disable "Start Scan" button
                btnStopScan.Enabled = true; // Enable "Stop Scan" button

                // Lấy thông tin giao diện mạng từ ComboBox
                string selectedInterface = comboBoxNetworkInterfaces.SelectedItem.ToString();

                // Lấy đối tượng NetworkInterface từ tên giao diện mạng
                NetworkInterface networkInterface = NetworkInterface.GetAllNetworkInterfaces()
                                                                   .FirstOrDefault(ni => ni.Name == selectedInterface);

                if (networkInterface == null)
                {
                    MessageBox.Show("Giao diện mạng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị địa chỉ mạng và subnet mask từ TextBox
                string networkAddressStr = txtNetworkAddress.Text;
                string subnetMaskStr = txtSubnetMask.Text;

                if (string.IsNullOrEmpty(networkAddressStr) || string.IsNullOrEmpty(subnetMaskStr))
                {
                    MessageBox.Show("Địa chỉ mạng hoặc subnet mask không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IPAddress networkAddress = IPAddress.Parse(networkAddressStr);
                IPAddress subnetMask = IPAddress.Parse(subnetMaskStr);

                // Tính toán địa chỉ mạng cơ sở và số lượng IP cần quét
                var ipRange = GetIpRange(networkAddress.ToString(), subnetMask.ToString());
                string baseIp = ipRange.Item1;
                string endIp = ipRange.Item2;

                progressBar.Value = 0;
                var temp = listViewIPs.Items[0];
                listViewIPs.Items.Clear();
                listViewIPs.Items.Add(temp);

                cancelTokenSource = new CancellationTokenSource();
                int startIpNumber = IPToNumber(baseIp) + 1;
                int endIpNumber = IPToNumber(endIp);
                int totalIPs = endIpNumber - startIpNumber + 1;
                int completedIPs = 0;

                // Chia IP thành 4 nhóm
                int rangeSize = totalIPs / 4;
                List<Task> tasks = new List<Task>();

                for (int j = 0; j < 4; j++)
                {
                    int start = startIpNumber + j * rangeSize;
                    int end = (j == 3) ? endIpNumber : start + rangeSize;

                    tasks.Add(Task.Run(async () =>
                    {
                        for (int i = start; i < end; i++)
                        {
                            if (cancelTokenSource.Token.IsCancellationRequested)
                                break;

                            string ipToPing = NumberToIP(i);

                            try
                            {
                                Ping ping = new Ping();
                                PingReply reply = await ping.SendPingAsync(ipToPing, 100);

                                if (reply.Status == IPStatus.Success)
                                {
                                    Invoke(new Action(() => listViewIPs.Items.Add(ipToPing)));
                                }
                            }
                            catch (Exception) { /* Bỏ qua lỗi */ }

                            // Cập nhật biến đếm và progressBar
                            Interlocked.Increment(ref completedIPs);
                            Invoke(new Action(() =>
                            {
                                float progressValue = (completedIPs * 100) / (float)totalIPs;
                                labelValue.Text = progressValue.ToString("F2") + "%";
                                progressBar.Value = (int)progressValue;
                            }));
                        }
                    }));
                }

                await Task.WhenAll(tasks);

                // Đảm bảo progressBar và labelValue đạt 100% sau khi hoàn tất
                labelValue.Text = "100%";
                progressBar.Value = 100;

                // Hoàn tất quét
                isScanning = false;
                btnStartScan.Enabled = true;
                btnStopScan.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giao diện mạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStopPortScanandListen_Click(object sender, EventArgs e)
        {
            if (checkBoxPort.Checked)
            {                
                if (!isPortScanning) return;
                cancelPortScanToken.Cancel();
                isPortScanning = false;

                btnStartPortScanandListen.Enabled = true; // Bật lại nút "Bắt đầu"
                btnStopPortScanandListen.Enabled = false; // Vô hiệu hóa nút "Dừng"
            }
            else if (checkBoxListen.Checked)
            {
                cancellationTokenSource.Cancel();
                btnStartPortScanandListen.Enabled = true; // Bật lại nút "Bắt đầu"
                btnStopPortScanandListen.Enabled = false; // Vô hiệu hóa nút "Dừng"
            }
        }

        //Scan Port

        // Class chứa thông tin của cổng
        public class PortDetails
        {
            public int PortNumber { get; set; }
            public string ProtocolType { get; set; }
            public string ServiceName { get; set; }

            public PortDetails(int portNumber, string protocolType, string serviceName)
            {
                PortNumber = portNumber;
                ProtocolType = protocolType;
                ServiceName = serviceName;
            }
        }

        // Danh sách các cổng phổ biến với số cổng, giao thức và dịch vụ tương ứng
        private PortDetails[] commonPortsList = {
            new PortDetails(21, "TCP", "FTP"),
            new PortDetails(22, "TCP", "SSH"),
            new PortDetails(23, "TCP", "Telnet"),
            new PortDetails(25, "TCP", "SMTP"),
            new PortDetails(53, "TCP/UDP", "DNS"),
            new PortDetails(80, "TCP", "HTTP"),
            new PortDetails(110, "TCP", "POP3"),
            new PortDetails(111, "TCP", "RPC"),
            new PortDetails(135, "TCP/UDP", "Microsoft EPMAP"),
            new PortDetails(137, "TCP/UDP", "NetBIOS"),
            new PortDetails(139, "TCP", "NetBIOS Session"),
            new PortDetails(143, "TCP", "IMAP"),
            new PortDetails(443, "TCP", "HTTPS"),
            new PortDetails(445, "TCP/UDP", "Microsoft Directory Services"),
            new PortDetails(993, "TCP", "IMAP SSL"),
            new PortDetails(995, "TCP", "POP3 SSL"),
            new PortDetails(1723, "TCP", "PPTP VPN"),
            new PortDetails(3306, "TCP", "MySQL"),
            new PortDetails(3389, "TCP", "Remote Desktop Protocol"),
            new PortDetails(5900, "TCP", "VNC"),
            new PortDetails(8080, "TCP", "HTTP Proxy"),
            new PortDetails(8443, "TCP", "HTTPS Alt"),
            new PortDetails(8888, "TCP", "HTTP Alt"),
            new PortDetails(9200, "TCP", "Elasticsearch"),
            new PortDetails(10000, "TCP", "Webmin")
        };


        // Hàm bắt đầu quá trình quét cổng
        private void ExecutePortScan(string ipAddressToScan, CancellationToken cancelToken)
        {
            int totalPortsToScan = commonPortsList.Length;

            // Sử dụng foreach để quét qua từng cổng
            foreach (PortDetails portDetail in commonPortsList)
            {
                if (cancelToken.IsCancellationRequested)
                    break;

                // Quét cổng và cập nhật giao diện
                ScanSinglePort(ipAddressToScan, portDetail);
            }
            // Kết thúc quá trình quét
            Invoke(new Action(() =>
            {
                isPortScanning = false;
                btnStartPortScanandListen.Enabled = true; // Bật lại nút "Bắt đầu"
                btnStopPortScanandListen.Enabled = false; // Vô hiệu hóa nút "Dừng"
                txtLogPortScanandListen.AppendText($"======== Quét cổng của địa chỉ {ipAddressToScan} hoàn tất! ========\r\n\r\n");
            }));
        }

        // Hàm quét một cổng
        private void ScanSinglePort(string ipAddressToScan, PortDetails portDetail)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    // Cố gắng kết nối đến địa chỉ IP và cổng
                    var result = tcpClient.BeginConnect(ipAddressToScan, portDetail.PortNumber, null, null);
                    bool success = result.AsyncWaitHandle.WaitOne(500); // Chờ 500ms để kết nối

                    if (success && tcpClient.Connected)
                    {
                        // Nếu kết nối thành công, hiển thị thông tin cổng mở
                        Invoke(new Action(() =>
                        {
                            txtLogPortScanandListen.AppendText($"Cổng: {portDetail.PortNumber}\r\n");
                            txtLogPortScanandListen.AppendText($"Giao thức: {portDetail.ProtocolType}\r\n");
                            txtLogPortScanandListen.AppendText($"Dịch vụ: {portDetail.ServiceName}\r\n\r\n");
                        }));
                    }
                }
            }
            catch (Exception)
            {
                // Bỏ qua lỗi, cổng không mở
            }
        }
        //Hàm lắng nghe thông điệp
        private async Task ListenMessage(IPAddress target, CancellationToken cancellationToken)
        {
            if (target == null)
            {
                return; // Nếu không chọn giao diện, thoát
            }

            txtLogPortScanandListen.AppendText($"\r\n--- Đang lắng nghe từ địa chỉ {target} ---\r\n");

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            socket.Bind(new IPEndPoint(target, 0));
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, true);

            byte[] bytesIn = new byte[4] { 1, 0, 0, 0 };
            byte[] bytesOut = new byte[4];
            socket.IOControl(IOControlCode.ReceiveAll, bytesIn, bytesOut);

            Task listenTask = new Task(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        byte[] bytesBuffer = new byte[socket.ReceiveBufferSize];
                        int bytesReceived = socket.Receive(bytesBuffer, bytesBuffer.Length, SocketFlags.None);

                        if (bytesReceived > 0)
                        {
                            IPPacket ipPacket = new IPPacket(bytesBuffer, bytesReceived);

                            if (ipPacket.SourceAddress.Equals(target))
                            {
                                LogPacketInfo(ipPacket);  // Hiển thị thông tin TCP/UDP và chuỗi hex
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        txtLogPortScanandListen.Invoke((Action)(() => txtLogPortScanandListen.AppendText($"\r\nLỗi: {ex.Message}\r\n")));
                    }
                }
            }, cancellationToken);

            listenTask.Start();
            await listenTask;

            txtLogPortScanandListen.AppendText("\r\n--- Kết thúc lắng nghe! ---\r\n");
        }
        private void LogPacketInfo(IPPacket ipPacket)
        {
            byte[] packetData = null; // Mảng byte để lưu dữ liệu gói tin

            if (ipPacket.Protocol == ProtocolType.Tcp)
            {
                TCPPacket tcpPacket = new TCPPacket(ipPacket.Data, ipPacket.Data.Length);
                packetData = tcpPacket.Data; // Lưu dữ liệu TCP vào mảng byte

            }
            else if (ipPacket.Protocol == ProtocolType.Udp)
            {
                UDPPacket udpPacket = new UDPPacket(ipPacket.Data, ipPacket.Data.Length);
                packetData = udpPacket.Data; // Lưu dữ liệu UDP vào mảng byte

            }

            // Chuyển mảng byte thành chuỗi hex và hiển thị
            if (packetData != null)
            {
                string hexString = BitConverter.ToString(packetData).Replace("-", " ").Replace("00", string.Empty);
                txtLogPortScanandListen.Invoke((Action)(() =>
                {
                    txtLogPortScanandListen.AppendText($"\r\nDữ liệu Hex: {hexString}\r\n");
                }));
            }
        }

        private async void btnStartPortScanandListen_Click(object sender, EventArgs e)
        {
            if (checkBoxPort.Checked)
            {
                
                if (isPortScanning) return;
                isPortScanning = true;
                btnStartPortScanandListen.Enabled = false; // Vô hiệu hóa nút "Bắt đầu"
                btnStopPortScanandListen.Enabled = true; // Kích hoạt nút "Dừng"

                // Lấy địa chỉ IP mục tiêu từ TextBox
                string ipAddressToScan = txtTargetIPAddress.Text;

                //txtLogPortScanandListen.Clear(); // Xóa nhật ký cũ
                txtLogPortScanandListen.AppendText($"-------- Quét cổng của địa chỉ {ipAddressToScan} --------\r\n\r\n");

                // Thực hiện quét cổng TCP
                cancelPortScanToken = new CancellationTokenSource();
                ThreadPool.QueueUserWorkItem(state => ExecutePortScan(ipAddressToScan, cancelPortScanToken.Token));
            }
            else if (checkBoxListen.Checked)
            {
                
                SelectInterfaceForm selectInterfaceForm = new SelectInterfaceForm();
                selectInterfaceForm.ShowDialog();
                if (selectInterfaceForm.selectedIPAddress == null)
                    return;
                txtTargetIPAddress.Clear();
                txtTargetIPAddress.Text = selectInterfaceForm.selectedIPAddress.ToString();
                cancellationTokenSource = new CancellationTokenSource();
                btnStartPortScanandListen.Enabled = false; // Vô hiệu hóa nút "Bắt đầu"
                btnStopPortScanandListen.Enabled = true; // Kích hoạt nút "Dừng"
                await ListenMessage(IPAddress.Parse(txtTargetIPAddress.Text), cancellationTokenSource.Token);

            }
            else
                MessageBox.Show("Vui lòng chọn 1 tính năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            if (!isScanning) return;
            cancelTokenSource.Cancel();
            isScanning = false;

            btnStartScan.Enabled = true; // Bật lại nút "Bắt đầu tìm"
            btnStopScan.Enabled = false; // Vô hiệu hóa nút "Dừng tìm"
        }

        private void comboBoxNetworkInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNetworkInterfaces.SelectedItem != null)
            {
                // Lấy tên giao diện mạng đã chọn
                string selectedInterface = comboBoxNetworkInterfaces.SelectedItem.ToString();

                // Lấy đối tượng NetworkInterface từ tên giao diện mạng
                NetworkInterface networkInterface = NetworkInterface.GetAllNetworkInterfaces()
                                                                   .FirstOrDefault(ni => ni.Name == selectedInterface);

                if (networkInterface == null)
                {
                    MessageBox.Show("Giao diện mạng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin IP và subnet mask của giao diện mạng
                var ipProperties = networkInterface.GetIPProperties();
                var unicastAddress = ipProperties.UnicastAddresses
                                                 .FirstOrDefault(addr => addr.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                if (unicastAddress == null)
                {
                    MessageBox.Show("Không tìm thấy địa chỉ IP hợp lệ cho giao diện mạng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy địa chỉ IP và subnet mask
                IPAddress ipAddress = unicastAddress.Address;
                IPAddress subnetMask = unicastAddress.IPv4Mask;

                // Tính toán địa chỉ mạng
                byte[] ipBytes = ipAddress.GetAddressBytes();
                byte[] subnetMaskBytes = subnetMask.GetAddressBytes();
                byte[] networkAddressBytes = new byte[ipBytes.Length];

                for (int i = 0; i < ipBytes.Length; i++)
                {
                    networkAddressBytes[i] = (byte)(ipBytes[i] & subnetMaskBytes[i]);
                }

                IPAddress networkAddress = new IPAddress(networkAddressBytes);

                // Hiển thị địa chỉ mạng và subnet mask vào các TextBox
                txtNetworkAddress.Text = networkAddress.ToString();  // Địa chỉ mạng
                txtSubnetMask.Text = subnetMask.ToString();          // Subnet mask

                // Hiển thị địa chỉ IP của máy vào txtCurrentIPAddress
                txtCurrentIPAddress.Text = ipAddress.ToString();  // Địa chỉ IP của máy
            }
        }

        private void btnNetSniff_Click(object sender, EventArgs e)
        {
            NetworkSniffer sni = new NetworkSniffer();
            sni.ShowDialog();
        }

        private void checkBoxPort_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxListen.Checked = false;
        }

        private void checkBoxListen_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPort.Checked = false;
        }
    }
}
