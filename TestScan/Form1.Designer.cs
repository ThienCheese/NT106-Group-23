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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Địa chỉ IP");
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNetSni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListenmesCheckBox = new System.Windows.Forms.CheckBox();
            this.QuetcongCheckBox = new System.Windows.Forms.CheckBox();
            this.btnStopPortScanandListen = new System.Windows.Forms.Button();
            this.btnStartPortScanandListen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogPortScanandListen = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ mạng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCurrentIPAddress
            // 
            this.txtCurrentIPAddress.Location = new System.Drawing.Point(11, 45);
            this.txtCurrentIPAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentIPAddress.Name = "txtCurrentIPAddress";
            this.txtCurrentIPAddress.Size = new System.Drawing.Size(111, 25);
            this.txtCurrentIPAddress.TabIndex = 3;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(11, 75);
            this.txtSubnetMask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(111, 25);
            this.txtSubnetMask.TabIndex = 4;
            // 
            // txtNetworkAddress
            // 
            this.txtNetworkAddress.Location = new System.Drawing.Point(11, 105);
            this.txtNetworkAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNetworkAddress.Name = "txtNetworkAddress";
            this.txtNetworkAddress.Size = new System.Drawing.Size(111, 25);
            this.txtNetworkAddress.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar.Location = new System.Drawing.Point(0, 238);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 21);
            this.progressBar.TabIndex = 6;
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackColor = System.Drawing.Color.Cyan;
            this.btnStartScan.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.Location = new System.Drawing.Point(178, 176);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(79, 28);
            this.btnStartScan.TabIndex = 7;
            this.btnStartScan.Text = "Bắt đầu tìm";
            this.btnStartScan.UseVisualStyleBackColor = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStopScan.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopScan.Location = new System.Drawing.Point(178, 207);
            this.btnStopScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(79, 28);
            this.btnStopScan.TabIndex = 8;
            this.btnStopScan.Text = "Dừng tìm";
            this.btnStopScan.UseVisualStyleBackColor = false;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // listViewIPs
            // 
            this.listViewIPs.BackColor = System.Drawing.Color.Bisque;
            this.listViewIPs.HideSelection = false;
            this.listViewIPs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewIPs.Location = new System.Drawing.Point(8, 265);
            this.listViewIPs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewIPs.Name = "listViewIPs";
            this.listViewIPs.Size = new System.Drawing.Size(261, 149);
            this.listViewIPs.TabIndex = 9;
            this.listViewIPs.UseCompatibleStateImageBehavior = false;
            this.listViewIPs.View = System.Windows.Forms.View.List;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(88, 219);
            this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(26, 18);
            this.labelValue.TabIndex = 10;
            this.labelValue.Text = "0%";
            this.labelValue.Click += new System.EventHandler(this.labelValue_Click);
            // 
            // comboBoxNetworkInterfaces
            // 
            this.comboBoxNetworkInterfaces.FormattingEnabled = true;
            this.comboBoxNetworkInterfaces.Location = new System.Drawing.Point(11, 14);
            this.comboBoxNetworkInterfaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNetworkInterfaces.Name = "comboBoxNetworkInterfaces";
            this.comboBoxNetworkInterfaces.Size = new System.Drawing.Size(111, 26);
            this.comboBoxNetworkInterfaces.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chọn giao diện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.btnStopScan);
            this.groupBox1.Controls.Add(this.btnStartScan);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(266, 448);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm địa chỉ cục bộ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 21);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxNetworkInterfaces);
            this.splitContainer1.Panel2.Controls.Add(this.txtNetworkAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtSubnetMask);
            this.splitContainer1.Panel2.Controls.Add(this.txtCurrentIPAddress);
            this.splitContainer1.Size = new System.Drawing.Size(260, 143);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đã quét được:";
            // 
            // btnNetSni
            // 
            this.btnNetSni.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNetSni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetSni.Location = new System.Drawing.Point(9, 416);
            this.btnNetSni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNetSni.Name = "btnNetSni";
            this.btnNetSni.Size = new System.Drawing.Size(260, 32);
            this.btnNetSni.TabIndex = 14;
            this.btnNetSni.Text = "Network Sniffer";
            this.btnNetSni.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListenmesCheckBox);
            this.groupBox2.Controls.Add(this.QuetcongCheckBox);
            this.groupBox2.Controls.Add(this.btnStopPortScanandListen);
            this.groupBox2.Controls.Add(this.btnStartPortScanandListen);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTargetIPAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(273, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(463, 448);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn công cụ";
            // 
            // ListenmesCheckBox
            // 
            this.ListenmesCheckBox.AutoSize = true;
            this.ListenmesCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenmesCheckBox.Location = new System.Drawing.Point(141, 94);
            this.ListenmesCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListenmesCheckBox.Name = "ListenmesCheckBox";
            this.ListenmesCheckBox.Size = new System.Drawing.Size(170, 23);
            this.ListenmesCheckBox.TabIndex = 9;
            this.ListenmesCheckBox.Text = "Lắng nghe thông điệp";
            this.ListenmesCheckBox.UseVisualStyleBackColor = true;
            // 
            // QuetcongCheckBox
            // 
            this.QuetcongCheckBox.AutoSize = true;
            this.QuetcongCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuetcongCheckBox.Location = new System.Drawing.Point(141, 66);
            this.QuetcongCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuetcongCheckBox.Name = "QuetcongCheckBox";
            this.QuetcongCheckBox.Size = new System.Drawing.Size(150, 23);
            this.QuetcongCheckBox.TabIndex = 9;
            this.QuetcongCheckBox.Text = "Quét cổng dịch vụ ";
            this.QuetcongCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnStopPortScanandListen
            // 
            this.btnStopPortScanandListen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStopPortScanandListen.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopPortScanandListen.Location = new System.Drawing.Point(358, 64);
            this.btnStopPortScanandListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStopPortScanandListen.Name = "btnStopPortScanandListen";
            this.btnStopPortScanandListen.Size = new System.Drawing.Size(84, 47);
            this.btnStopPortScanandListen.TabIndex = 8;
            this.btnStopPortScanandListen.Text = "Dừng";
            this.btnStopPortScanandListen.UseVisualStyleBackColor = false;
            this.btnStopPortScanandListen.Click += new System.EventHandler(this.btnStopPortScanandListen_Click);
            // 
            // btnStartPortScanandListen
            // 
            this.btnStartPortScanandListen.BackColor = System.Drawing.Color.Cyan;
            this.btnStartPortScanandListen.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPortScanandListen.Location = new System.Drawing.Point(358, 11);
            this.btnStartPortScanandListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartPortScanandListen.Name = "btnStartPortScanandListen";
            this.btnStartPortScanandListen.Size = new System.Drawing.Size(84, 47);
            this.btnStartPortScanandListen.TabIndex = 7;
            this.btnStartPortScanandListen.Text = "Bắt đầu";
            this.btnStartPortScanandListen.UseVisualStyleBackColor = false;
            this.btnStartPortScanandListen.Click += new System.EventHandler(this.btnStartPortScanandListen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogPortScanandListen);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(450, 326);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng ghi";
            // 
            // txtLogPortScanandListen
            // 
            this.txtLogPortScanandListen.BackColor = System.Drawing.Color.Bisque;
            this.txtLogPortScanandListen.Location = new System.Drawing.Point(0, 28);
            this.txtLogPortScanandListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogPortScanandListen.Multiline = true;
            this.txtLogPortScanandListen.Name = "txtLogPortScanandListen";
            this.txtLogPortScanandListen.ReadOnly = true;
            this.txtLogPortScanandListen.Size = new System.Drawing.Size(446, 296);
            this.txtLogPortScanandListen.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tính năng";
            // 
            // txtTargetIPAddress
            // 
            this.txtTargetIPAddress.Location = new System.Drawing.Point(141, 20);
            this.txtTargetIPAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTargetIPAddress.Name = "txtTargetIPAddress";
            this.txtTargetIPAddress.Size = new System.Drawing.Size(134, 25);
            this.txtTargetIPAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ IP mục tiêu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.listViewIPs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNetSni);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "NetworkScanner";
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
        private System.Windows.Forms.TextBox txtLogPortScanandListen;
        private System.Windows.Forms.Button btnStartPortScanandListen;
        private System.Windows.Forms.Button btnStopPortScanandListen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox ListenmesCheckBox;
        private System.Windows.Forms.CheckBox QuetcongCheckBox;
    }
}

