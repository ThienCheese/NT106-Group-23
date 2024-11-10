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
            if (_device != null)
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
            while (_isCapturing)
            {
                Capture();
                Thread.Sleep(100);
                Stop();
                Thread.Sleep(100);
            }
        }

        private void InitializeListView()
        {
            listViewPackets.Columns.Add("Time", 150);
            listViewPackets.Columns.Add("Source", 150);
            listViewPackets.Columns.Add("Destination", 150);
            listViewPackets.Columns.Add("Protocol", 150);
            listViewPackets.Columns.Add("Length", 100);
            listViewPackets.Columns.Add("Content", 50);

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
            string payload = "";

            if (packet is EthernetPacket ethernetPacket)
            {
                if (ethernetPacket.PayloadPacket is IPv4Packet ipPacket)
                {
                    source = ipPacket.SourceAddress.ToString();
                    destination = ipPacket.DestinationAddress.ToString();
                    protocol = ipPacket.Protocol.ToString();
                    payload = ipPacket.PayloadPacket.ToString();
                }
                else if (ethernetPacket.PayloadPacket is IPv6Packet ipv6Packet)
                {
                    source = ipv6Packet.SourceAddress.ToString();
                    destination = ipv6Packet.DestinationAddress.ToString();
                    protocol = "IPv6";
                }
            }

            listViewPackets.Invoke(new Action(() =>
            {
                ListViewItem item = new ListViewItem(time);
                item.SubItems.Add(source);
                item.SubItems.Add(destination);
                item.SubItems.Add(protocol);
                item.SubItems.Add(size.ToString());
                item.SubItems.Add(payload);
                listViewPackets.Items.Add(item);
            }));

            _captureWriter.Write(rawPacket);
        }

        private void listViewPackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPackets.SelectedItems.Count > 0)
            {
                var payload = listViewPackets.SelectedItems[0].SubItems[5].Text;
                textBoxDetails.Text = payload;

                treeViewPacketDetails.Nodes.Clear();
                var selectedItem = listViewPackets.SelectedItems[0];

                TreeNode rootNode = new TreeNode("Packet Details");
                rootNode.Nodes.Add("Time: " + selectedItem.SubItems[0].Text);
                rootNode.Nodes.Add("Source: " + selectedItem.SubItems[1].Text);
                rootNode.Nodes.Add("Destination: " + selectedItem.SubItems[2].Text);
                rootNode.Nodes.Add("Protocol: " + selectedItem.SubItems[3].Text);
                rootNode.Nodes.Add("Length: " + selectedItem.SubItems[4].Text);
                rootNode.Nodes.Add("Payload: " + payload);

                treeViewPacketDetails.Nodes.Add(rootNode);
                treeViewPacketDetails.ExpandAll();
            }
        }

        private void SaveCapture_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PCAP Files|*.pcap";
                saveFileDialog.Title = "Save Captured Packets";
                

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
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
