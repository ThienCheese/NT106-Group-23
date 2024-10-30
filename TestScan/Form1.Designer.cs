namespace TestScan
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Địa chỉ IP");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentIPAddress = new System.Windows.Forms.TextBox();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.txtNetworkAddress = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.listViewIPs = new System.Windows.Forms.ListView();
            this.labelValue = new System.Windows.Forms.Label();
            this.comboBoxNetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNetSni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStopPortScanandListen = new System.Windows.Forms.Button();
            this.btnStartPortScanandListen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogPortScanandListen = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTargetIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ mạng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCurrentIPAddress
            // 
            this.txtCurrentIPAddress.Location = new System.Drawing.Point(115, 89);
            this.txtCurrentIPAddress.Name = "txtCurrentIPAddress";
            this.txtCurrentIPAddress.Size = new System.Drawing.Size(128, 26);
            this.txtCurrentIPAddress.TabIndex = 3;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(115, 121);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(128, 26);
            this.txtSubnetMask.TabIndex = 4;
            // 
            // txtNetworkAddress
            // 
            this.txtNetworkAddress.Location = new System.Drawing.Point(115, 153);
            this.txtNetworkAddress.Name = "txtNetworkAddress";
            this.txtNetworkAddress.Size = new System.Drawing.Size(128, 26);
            this.txtNetworkAddress.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar.Location = new System.Drawing.Point(6, 263);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(237, 33);
            this.progressBar.TabIndex = 6;
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(4, 185);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(105, 43);
            this.btnStartScan.TabIndex = 7;
            this.btnStartScan.Text = "Bắt đầu tìm";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(132, 185);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(111, 43);
            this.btnStopScan.TabIndex = 8;
            this.btnStopScan.Text = "Dừng tìm";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // listViewIPs
            // 
            this.listViewIPs.HideSelection = false;
            this.listViewIPs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewIPs.Location = new System.Drawing.Point(5, 302);
            this.listViewIPs.Name = "listViewIPs";
            this.listViewIPs.Size = new System.Drawing.Size(238, 227);
            this.listViewIPs.TabIndex = 9;
            this.listViewIPs.UseCompatibleStateImageBehavior = false;
            this.listViewIPs.View = System.Windows.Forms.View.List;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(97, 231);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(32, 20);
            this.labelValue.TabIndex = 10;
            this.labelValue.Text = "0%";
            this.labelValue.Click += new System.EventHandler(this.labelValue_Click);
            // 
            // comboBoxNetworkInterfaces
            // 
            this.comboBoxNetworkInterfaces.FormattingEnabled = true;
            this.comboBoxNetworkInterfaces.Location = new System.Drawing.Point(4, 55);
            this.comboBoxNetworkInterfaces.Name = "comboBoxNetworkInterfaces";
            this.comboBoxNetworkInterfaces.Size = new System.Drawing.Size(237, 28);
            this.comboBoxNetworkInterfaces.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chọn giao diện mạng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewIPs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxNetworkInterfaces);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCurrentIPAddress);
            this.groupBox1.Controls.Add(this.btnStopScan);
            this.groupBox1.Controls.Add(this.txtSubnetMask);
            this.groupBox1.Controls.Add(this.btnStartScan);
            this.groupBox1.Controls.Add(this.txtNetworkAddress);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 532);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm địa chỉ cục bộ";
            // 
            // btnNetSni
            // 
            this.btnNetSni.Location = new System.Drawing.Point(18, 542);
            this.btnNetSni.Name = "btnNetSni";
            this.btnNetSni.Size = new System.Drawing.Size(237, 38);
            this.btnNetSni.TabIndex = 14;
            this.btnNetSni.Text = "Network Sniffer";
            this.btnNetSni.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStopPortScanandListen);
            this.groupBox2.Controls.Add(this.btnStartPortScanandListen);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTargetIPAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(279, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 575);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các công cụ";
            // 
            // btnStopPortScanandListen
            // 
            this.btnStopPortScanandListen.Location = new System.Drawing.Point(485, 21);
            this.btnStopPortScanandListen.Name = "btnStopPortScanandListen";
            this.btnStopPortScanandListen.Size = new System.Drawing.Size(126, 72);
            this.btnStopPortScanandListen.TabIndex = 8;
            this.btnStopPortScanandListen.Text = "Dừng";
            this.btnStopPortScanandListen.UseVisualStyleBackColor = true;
            this.btnStopPortScanandListen.Click += new System.EventHandler(this.btnStopPortScanandListen_Click);
            // 
            // btnStartPortScanandListen
            // 
            this.btnStartPortScanandListen.Location = new System.Drawing.Point(337, 21);
            this.btnStartPortScanandListen.Name = "btnStartPortScanandListen";
            this.btnStartPortScanandListen.Size = new System.Drawing.Size(126, 72);
            this.btnStartPortScanandListen.TabIndex = 7;
            this.btnStartPortScanandListen.Text = "Bắt đầu";
            this.btnStartPortScanandListen.UseVisualStyleBackColor = true;
            this.btnStartPortScanandListen.Click += new System.EventHandler(this.btnStartPortScanandListen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogPortScanandListen);
            this.groupBox3.Location = new System.Drawing.Point(6, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 476);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng ghi";
            // 
            // txtLogPortScanandListen
            // 
            this.txtLogPortScanandListen.Location = new System.Drawing.Point(10, 26);
            this.txtLogPortScanandListen.Multiline = true;
            this.txtLogPortScanandListen.Name = "txtLogPortScanandListen";
            this.txtLogPortScanandListen.ReadOnly = true;
            this.txtLogPortScanandListen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogPortScanandListen.Size = new System.Drawing.Size(595, 444);
            this.txtLogPortScanandListen.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Quét cổng TCP",
            "Lắng nghe thông điệp"});
            this.comboBox2.Location = new System.Drawing.Point(101, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tính năng";
            // 
            // txtTargetIPAddress
            // 
            this.txtTargetIPAddress.Location = new System.Drawing.Point(162, 29);
            this.txtTargetIPAddress.Name = "txtTargetIPAddress";
            this.txtTargetIPAddress.Size = new System.Drawing.Size(150, 26);
            this.txtTargetIPAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ IP mục tiêu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNetSni);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentIPAddress;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.TextBox txtNetworkAddress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.ListView listViewIPs;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxNetworkInterfaces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNetSni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTargetIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtLogPortScanandListen;
        private System.Windows.Forms.Button btnStartPortScanandListen;
        private System.Windows.Forms.Button btnStopPortScanandListen;
    }
}

