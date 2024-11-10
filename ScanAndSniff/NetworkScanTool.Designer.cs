namespace ScanAndSniff
{
    partial class NetworkScanTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Địa chỉ IP");
            this.comboBoxNetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNetSniff = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.listViewIPs = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.txtNetworkAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogPortScanandListen = new System.Windows.Forms.RichTextBox();
            this.btnStopPortScanandListen = new System.Windows.Forms.Button();
            this.btnStartPortScanandListen = new System.Windows.Forms.Button();
            this.cmbScanPortandListen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTargetIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNetworkInterfaces
            // 
            this.comboBoxNetworkInterfaces.FormattingEnabled = true;
            this.comboBoxNetworkInterfaces.Location = new System.Drawing.Point(4, 41);
            this.comboBoxNetworkInterfaces.Name = "comboBoxNetworkInterfaces";
            this.comboBoxNetworkInterfaces.Size = new System.Drawing.Size(264, 28);
            this.comboBoxNetworkInterfaces.TabIndex = 0;
            this.comboBoxNetworkInterfaces.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetworkInterfaces_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnNetSniff);
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.listViewIPs);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.btnStopScan);
            this.groupBox1.Controls.Add(this.btnStartScan);
            this.groupBox1.Controls.Add(this.txtSubnetMask);
            this.groupBox1.Controls.Add(this.txtNetworkAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCurrentIPAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxNetworkInterfaces);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 635);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm địa chỉ cục bộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ mạng";
            // 
            // btnNetSniff
            // 
            this.btnNetSniff.Location = new System.Drawing.Point(6, 577);
            this.btnNetSniff.Name = "btnNetSniff";
            this.btnNetSniff.Size = new System.Drawing.Size(262, 53);
            this.btnNetSniff.TabIndex = 13;
            this.btnNetSniff.Text = "Network Sniffer";
            this.btnNetSniff.UseVisualStyleBackColor = true;
            this.btnNetSniff.Click += new System.EventHandler(this.btnNetSniff_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(102, 239);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(32, 20);
            this.labelValue.TabIndex = 12;
            this.labelValue.Text = "0%";
            // 
            // listViewIPs
            // 
            this.listViewIPs.HideSelection = false;
            this.listViewIPs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewIPs.Location = new System.Drawing.Point(6, 318);
            this.listViewIPs.Name = "listViewIPs";
            this.listViewIPs.Size = new System.Drawing.Size(262, 253);
            this.listViewIPs.TabIndex = 11;
            this.listViewIPs.UseCompatibleStateImageBehavior = false;
            this.listViewIPs.View = System.Windows.Forms.View.List;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 272);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(262, 40);
            this.progressBar.TabIndex = 10;
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(140, 187);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(125, 40);
            this.btnStopScan.TabIndex = 9;
            this.btnStopScan.Text = "Dừng tìm";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(6, 187);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(120, 40);
            this.btnStartScan.TabIndex = 8;
            this.btnStartScan.Text = "Bắt đầu tìm";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(106, 143);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = true;
            this.txtSubnetMask.Size = new System.Drawing.Size(162, 26);
            this.txtSubnetMask.TabIndex = 7;
            // 
            // txtNetworkAddress
            // 
            this.txtNetworkAddress.Location = new System.Drawing.Point(106, 110);
            this.txtNetworkAddress.Name = "txtNetworkAddress";
            this.txtNetworkAddress.ReadOnly = true;
            this.txtNetworkAddress.Size = new System.Drawing.Size(162, 26);
            this.txtNetworkAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subnet Mask";
            // 
            // txtCurrentIPAddress
            // 
            this.txtCurrentIPAddress.Location = new System.Drawing.Point(106, 78);
            this.txtCurrentIPAddress.Name = "txtCurrentIPAddress";
            this.txtCurrentIPAddress.ReadOnly = true;
            this.txtCurrentIPAddress.Size = new System.Drawing.Size(162, 26);
            this.txtCurrentIPAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn giao diện mạng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnStopPortScanandListen);
            this.groupBox2.Controls.Add(this.btnStartPortScanandListen);
            this.groupBox2.Controls.Add(this.cmbScanPortandListen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTargetIPAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 635);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các công cụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogPortScanandListen);
            this.groupBox3.Location = new System.Drawing.Point(6, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 541);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bản ghi";
            // 
            // txtLogPortScanandListen
            // 
            this.txtLogPortScanandListen.Location = new System.Drawing.Point(6, 25);
            this.txtLogPortScanandListen.Name = "txtLogPortScanandListen";
            this.txtLogPortScanandListen.ReadOnly = true;
            this.txtLogPortScanandListen.Size = new System.Drawing.Size(583, 520);
            this.txtLogPortScanandListen.TabIndex = 0;
            this.txtLogPortScanandListen.Text = "";
            // 
            // btnStopPortScanandListen
            // 
            this.btnStopPortScanandListen.Location = new System.Drawing.Point(483, 19);
            this.btnStopPortScanandListen.Name = "btnStopPortScanandListen";
            this.btnStopPortScanandListen.Size = new System.Drawing.Size(119, 63);
            this.btnStopPortScanandListen.TabIndex = 5;
            this.btnStopPortScanandListen.Text = "Dừng";
            this.btnStopPortScanandListen.UseVisualStyleBackColor = true;
            this.btnStopPortScanandListen.Click += new System.EventHandler(this.btnStopPortScanandListen_Click);
            // 
            // btnStartPortScanandListen
            // 
            this.btnStartPortScanandListen.Location = new System.Drawing.Point(358, 19);
            this.btnStartPortScanandListen.Name = "btnStartPortScanandListen";
            this.btnStartPortScanandListen.Size = new System.Drawing.Size(119, 63);
            this.btnStartPortScanandListen.TabIndex = 4;
            this.btnStartPortScanandListen.Text = "Bắt đầu";
            this.btnStartPortScanandListen.UseVisualStyleBackColor = true;
            this.btnStartPortScanandListen.Click += new System.EventHandler(this.btnStartPortScanandListen_Click);
            // 
            // cmbScanPortandListen
            // 
            this.cmbScanPortandListen.FormattingEnabled = true;
            this.cmbScanPortandListen.Items.AddRange(new object[] {
            "Quét cổng",
            "Lắng nghe thông điệp"});
            this.cmbScanPortandListen.Location = new System.Drawing.Point(129, 54);
            this.cmbScanPortandListen.Name = "cmbScanPortandListen";
            this.cmbScanPortandListen.Size = new System.Drawing.Size(214, 28);
            this.cmbScanPortandListen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chọn tính năng";
            // 
            // txtTargetIPAddress
            // 
            this.txtTargetIPAddress.Location = new System.Drawing.Point(152, 19);
            this.txtTargetIPAddress.Name = "txtTargetIPAddress";
            this.txtTargetIPAddress.Size = new System.Drawing.Size(191, 26);
            this.txtTargetIPAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ IP mục tiêu";
            // 
            // NetworkScanTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NetworkScanTool";
            this.Text = "NetworkScanTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNetworkInterfaces;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.TextBox txtNetworkAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView listViewIPs;
        private System.Windows.Forms.Button btnNetSniff;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartPortScanandListen;
        private System.Windows.Forms.ComboBox cmbScanPortandListen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTargetIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStopPortScanandListen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtLogPortScanandListen;
        private System.Windows.Forms.Label label4;
    }
}

