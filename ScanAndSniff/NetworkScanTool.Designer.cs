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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Địa chỉ IP");
            this.comboBoxNetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNetworkAddress = new System.Windows.Forms.TextBox();
            this.txtCurrentIPAddress = new System.Windows.Forms.TextBox();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.btnNetSniff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.listViewIPs = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPort = new System.Windows.Forms.CheckBox();
            this.checkBoxListen = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogPortScanandListen = new System.Windows.Forms.RichTextBox();
            this.btnStopPortScanandListen = new System.Windows.Forms.Button();
            this.btnStartPortScanandListen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTargetIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNetworkInterfaces
            // 
            this.comboBoxNetworkInterfaces.FormattingEnabled = true;
            this.comboBoxNetworkInterfaces.Location = new System.Drawing.Point(10, 25);
            this.comboBoxNetworkInterfaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNetworkInterfaces.Name = "comboBoxNetworkInterfaces";
            this.comboBoxNetworkInterfaces.Size = new System.Drawing.Size(144, 31);
            this.comboBoxNetworkInterfaces.TabIndex = 0;
            this.comboBoxNetworkInterfaces.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetworkInterfaces_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.btnNetSniff);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.listViewIPs);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.btnStopScan);
            this.groupBox1.Controls.Add(this.btnStartScan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(338, 753);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm địa chỉ IP cục bộ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(6, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtNetworkAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtCurrentIPAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtSubnetMask);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxNetworkInterfaces);
            this.splitContainer1.Size = new System.Drawing.Size(326, 219);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ mạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subnet Mask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn giao \r\ndiện mạng";
            // 
            // txtNetworkAddress
            // 
            this.txtNetworkAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetworkAddress.Location = new System.Drawing.Point(10, 123);
            this.txtNetworkAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNetworkAddress.Name = "txtNetworkAddress";
            this.txtNetworkAddress.ReadOnly = true;
            this.txtNetworkAddress.Size = new System.Drawing.Size(144, 30);
            this.txtNetworkAddress.TabIndex = 5;
            // 
            // txtCurrentIPAddress
            // 
            this.txtCurrentIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentIPAddress.Location = new System.Drawing.Point(10, 75);
            this.txtCurrentIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentIPAddress.Name = "txtCurrentIPAddress";
            this.txtCurrentIPAddress.ReadOnly = true;
            this.txtCurrentIPAddress.Size = new System.Drawing.Size(144, 30);
            this.txtCurrentIPAddress.TabIndex = 3;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubnetMask.Location = new System.Drawing.Point(10, 166);
            this.txtSubnetMask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = true;
            this.txtSubnetMask.Size = new System.Drawing.Size(144, 30);
            this.txtSubnetMask.TabIndex = 7;
            // 
            // btnNetSniff
            // 
            this.btnNetSniff.BackColor = System.Drawing.Color.Tomato;
            this.btnNetSniff.Location = new System.Drawing.Point(6, 713);
            this.btnNetSniff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNetSniff.Name = "btnNetSniff";
            this.btnNetSniff.Size = new System.Drawing.Size(326, 36);
            this.btnNetSniff.TabIndex = 13;
            this.btnNetSniff.Text = "Network Sniffer";
            this.btnNetSniff.UseVisualStyleBackColor = false;
            this.btnNetSniff.Click += new System.EventHandler(this.btnNetSniff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiến độ:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(94, 367);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(33, 23);
            this.labelValue.TabIndex = 12;
            this.labelValue.Text = "0%";
            // 
            // listViewIPs
            // 
            this.listViewIPs.BackColor = System.Drawing.Color.Bisque;
            this.listViewIPs.HideSelection = false;
            this.listViewIPs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11});
            this.listViewIPs.Location = new System.Drawing.Point(6, 428);
            this.listViewIPs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewIPs.Name = "listViewIPs";
            this.listViewIPs.Size = new System.Drawing.Size(326, 281);
            this.listViewIPs.TabIndex = 11;
            this.listViewIPs.UseCompatibleStateImageBehavior = false;
            this.listViewIPs.View = System.Windows.Forms.View.List;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 392);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(326, 32);
            this.progressBar.TabIndex = 10;
            // 
            // btnStopScan
            // 
            this.btnStopScan.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStopScan.Location = new System.Drawing.Point(189, 328);
            this.btnStopScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(143, 42);
            this.btnStopScan.TabIndex = 9;
            this.btnStopScan.Text = "Dừng tìm";
            this.btnStopScan.UseVisualStyleBackColor = false;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackColor = System.Drawing.Color.Aqua;
            this.btnStartScan.Location = new System.Drawing.Point(189, 277);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(143, 47);
            this.btnStartScan.TabIndex = 8;
            this.btnStartScan.Text = "Bắt đầu tìm";
            this.btnStartScan.UseVisualStyleBackColor = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.checkBoxPort);
            this.groupBox2.Controls.Add(this.checkBoxListen);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnStopPortScanandListen);
            this.groupBox2.Controls.Add(this.btnStartPortScanandListen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTargetIPAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(338, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(644, 753);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các công cụ";
            // 
            // checkBoxPort
            // 
            this.checkBoxPort.AutoSize = true;
            this.checkBoxPort.BackColor = System.Drawing.Color.Linen;
            this.checkBoxPort.Location = new System.Drawing.Point(178, 128);
            this.checkBoxPort.Name = "checkBoxPort";
            this.checkBoxPort.Size = new System.Drawing.Size(109, 27);
            this.checkBoxPort.TabIndex = 1;
            this.checkBoxPort.Text = "Quét cổng";
            this.checkBoxPort.UseVisualStyleBackColor = false;
            this.checkBoxPort.CheckedChanged += new System.EventHandler(this.checkBoxPort_CheckedChanged);
            // 
            // checkBoxListen
            // 
            this.checkBoxListen.AutoSize = true;
            this.checkBoxListen.Location = new System.Drawing.Point(178, 173);
            this.checkBoxListen.Name = "checkBoxListen";
            this.checkBoxListen.Size = new System.Drawing.Size(196, 27);
            this.checkBoxListen.TabIndex = 1;
            this.checkBoxListen.Text = "Lắng nghe thông điệp";
            this.checkBoxListen.UseVisualStyleBackColor = true;
            this.checkBoxListen.CheckedChanged += new System.EventHandler(this.checkBoxListen_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogPortScanandListen);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 220);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(630, 529);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bản ghi";
            // 
            // txtLogPortScanandListen
            // 
            this.txtLogPortScanandListen.BackColor = System.Drawing.Color.PeachPuff;
            this.txtLogPortScanandListen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogPortScanandListen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogPortScanandListen.Location = new System.Drawing.Point(3, 25);
            this.txtLogPortScanandListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogPortScanandListen.Name = "txtLogPortScanandListen";
            this.txtLogPortScanandListen.ReadOnly = true;
            this.txtLogPortScanandListen.Size = new System.Drawing.Size(624, 502);
            this.txtLogPortScanandListen.TabIndex = 0;
            this.txtLogPortScanandListen.Text = "";
            // 
            // btnStopPortScanandListen
            // 
            this.btnStopPortScanandListen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStopPortScanandListen.Location = new System.Drawing.Point(529, 115);
            this.btnStopPortScanandListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopPortScanandListen.Name = "btnStopPortScanandListen";
            this.btnStopPortScanandListen.Size = new System.Drawing.Size(106, 50);
            this.btnStopPortScanandListen.TabIndex = 5;
            this.btnStopPortScanandListen.Text = "Dừng";
            this.btnStopPortScanandListen.UseVisualStyleBackColor = false;
            this.btnStopPortScanandListen.Click += new System.EventHandler(this.btnStopPortScanandListen_Click);
            // 
            // btnStartPortScanandListen
            // 
            this.btnStartPortScanandListen.BackColor = System.Drawing.Color.Cyan;
            this.btnStartPortScanandListen.Location = new System.Drawing.Point(526, 40);
            this.btnStartPortScanandListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartPortScanandListen.Name = "btnStartPortScanandListen";
            this.btnStartPortScanandListen.Size = new System.Drawing.Size(106, 50);
            this.btnStartPortScanandListen.TabIndex = 4;
            this.btnStartPortScanandListen.Text = "Bắt đầu";
            this.btnStartPortScanandListen.UseVisualStyleBackColor = false;
            this.btnStartPortScanandListen.Click += new System.EventHandler(this.btnStartPortScanandListen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chọn tính năng";
            // 
            // txtTargetIPAddress
            // 
            this.txtTargetIPAddress.Location = new System.Drawing.Point(178, 67);
            this.txtTargetIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetIPAddress.Name = "txtTargetIPAddress";
            this.txtTargetIPAddress.Size = new System.Drawing.Size(170, 30);
            this.txtTargetIPAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ IP mục tiêu";
            // 
            // NetworkScanTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NetworkScanTool";
            this.Text = "NetworkScanTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTargetIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStopPortScanandListen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtLogPortScanandListen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxListen;
        private System.Windows.Forms.CheckBox checkBoxPort;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
    }
}

