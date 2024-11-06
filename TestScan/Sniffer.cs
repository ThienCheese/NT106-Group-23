using System;
using System.Windows.Forms;
using SharpPcap;
using PacketDotNet;
using SharpPcap.LibPcap;
using PacketDotNet.Ieee80211;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace LastNetworkSniffer
{
    public partial class Sniffer : Form
    {
        private ICaptureDevice _device;
        private CaptureFileWriterDevice _captureWriter;
        private bool _isCapturing = false;
        public Sniffer()
        {
            InitializeComponent();
            LoadNetworkInterfaces();
        }
        private void LoadNetworkInterfaces()
        {
            comboBoxInterfaces.Items.Clear();
            foreach (var dev in CaptureDeviceList.Instance)
            {
                comboBoxInterfaces.Items.Add(dev.Description);
            }
        }
        private void StartCapture_Click(object sender, EventArgs e)
        {
            _isCapturing = true;
            Thread thread = new Thread(Repeat);
            thread.Start();
        }
        private void StopCapture_Click(object sender, EventArgs e)
        {
            _isCapturing = false;
        }
        private void Capture()
        {
            int selectedIndex = comboBoxInterfaces.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a network interface!");
                return;
            }

            _device = CaptureDeviceList.Instance[selectedIndex];
            _device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);



            _captureWriter = new CaptureFileWriterDevice("captured_packets.pcap");

            Task.Run(() =>
            {
                _device.Open(DeviceModes.Promiscuous, read_timeout: 1000);
                _device.StartCapture();
            });
        }
        private void Stop()
        {
            if (_device != null) // Ensure device is open and capturing
            {
                _device.StopCapture();
                _device.Close();

            }

            if (_captureWriter != null)
            {
                _captureWriter.Close();
                _captureWriter = null;
            }
        }
        private async void Repeat()
        {
            while(_isCapturing)
            {
                Capture();
                Thread.Sleep(100);
                Stop();
                Thread.Sleep(100);
            }
        }
        private void InitializeListView()
        {
            // Thêm các cột vào ListView
            listViewPackets.Columns.Add("Time", 150);
            listViewPackets.Columns.Add("Source", 150);
            listViewPackets.Columns.Add("Destination", 150);
            listViewPackets.Columns.Add("Protocol", 150);
            listViewPackets.Columns.Add("Length", 150);

            // Chế độ xem của ListView là Details
            listViewPackets.View = View.Details;
            listViewPackets.FullRowSelect = true;
        }
        private void OnPacketArrival(object sender, PacketCapture e)
        {

            var rawPacket = e.GetPacket();
            var packet = PacketDotNet.Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);
            var time = rawPacket.Timeval.Date.ToString("yyyy-MM-dd HH:mm:ss");
            var size = rawPacket.Data.Length;

            string source = "";
            string destination = "";
            string protocol = "";

            if (packet is EthernetPacket ethernetPacket)
            {
                if (ethernetPacket.PayloadPacket is IPv4Packet ipPacket)
                {
                    source = ipPacket.SourceAddress.ToString();
                    destination = ipPacket.DestinationAddress.ToString();
                    if (ipPacket.Protocol.ToString() == "TCP")                   
                        protocol = "TCP";                   
                    else if (ipPacket.Protocol.ToString() == "UDP")
                        protocol = "UDP";
                    else protocol = "Other";
                }
                else if (ethernetPacket.PayloadPacket is IPv6Packet ipv6Packet)
                {
                    source = ipv6Packet.SourceAddress.ToString();
                    destination = ipv6Packet.DestinationAddress.ToString();
                    protocol = "IPv6";
                }
            }

            // Add packet details to ListView
            listViewPackets.Invoke(new Action(() =>
            {
                ListViewItem item = new ListViewItem(time);
                item.SubItems.Add(source);
                item.SubItems.Add(destination);
                item.SubItems.Add(protocol);
                item.SubItems.Add(size.ToString());
                item.SubItems.Add(packet.PayloadData.ToString());
                listViewPackets.Items.Add(item);
            }));

            // Write packet to capture file
            _captureWriter.Write(rawPacket);
        }
        private void listViewPackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPackets.SelectedItems.Count > 0)
            {
                var packet = listViewPackets.SelectedItems[0].SubItems[5].Text;
                textBoxDetails.Text = packet;
            }
        }
        private void SaveCapture_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PCAP Files|*.pcap";
                saveFileDialog.Title = "Save Captured Packets";
                saveFileDialog.FileName = "captured_packets.pcap";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đổi tên tệp lưu từ mặc định thành tệp do người dùng chọn
                    File.Move("captured_packets.pcap", saveFileDialog.FileName);
                    MessageBox.Show("Packets saved successfully!");
                }
            }
        }
        private void Sniffer_Load(object sender, EventArgs e)
        {
            InitializeListView();
        }
    }
}
