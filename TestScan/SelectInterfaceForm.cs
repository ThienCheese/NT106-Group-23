using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScan
{
    public partial class SelectInterfaceForm : Form
    {
        public IPAddress selectedIPAddress { get; private set; }
        public SelectInterfaceForm()
        {
            InitializeComponent();
            LoadNetworkInterfaces();
        }

        // Hàm để tải danh sách các giao diện mạng vào comboBoxNetworkInterfaces
        private void LoadNetworkInterfaces()
        {
            comboBoxNetworkInterfaces.Items.Clear();
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                comboBoxNetworkInterfaces.Items.Add(netInterface.Name);
            }

        }


        // Hàm để tải các địa chỉ IP của giao diện mạng đã chọn
        private void LoadIPAddressesForSelectedInterface()
        {
            comboBoxIPAddresses.Items.Clear();

            string selectedInterfaceName = comboBoxNetworkInterfaces.SelectedItem.ToString();
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
                        comboBoxIPAddresses.Items.Add(ipInfo.Address.ToString());
                    }
                }
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxIPAddresses.SelectedItem != null)
            {
                selectedIPAddress = IPAddress.Parse(comboBoxIPAddresses.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa chỉ IP.");
            }
        }

        // Khi người dùng chọn giao diện mạng từ comboBoxNetworkInterfaces
        private void comboBoxNetworkInterfaces_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadIPAddressesForSelectedInterface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
