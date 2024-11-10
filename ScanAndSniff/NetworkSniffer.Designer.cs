namespace ScanAndSniff
{
    partial class NetworkSniffer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHexToText = new System.Windows.Forms.Button();
            this.btnTextToHex = new System.Windows.Forms.Button();
            this.rtxtHexData = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbNetworkInterface = new System.Windows.Forms.ComboBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.treeViewPacketDetails = new System.Windows.Forms.TreeView();
            this.listViewPackets = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHexToText);
            this.groupBox1.Controls.Add(this.btnTextToHex);
            this.groupBox1.Controls.Add(this.rtxtHexData);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(598, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 314);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload";
            // 
            // btnHexToText
            // 
            this.btnHexToText.Location = new System.Drawing.Point(153, 279);
            this.btnHexToText.Name = "btnHexToText";
            this.btnHexToText.Size = new System.Drawing.Size(101, 31);
            this.btnHexToText.TabIndex = 12;
            this.btnHexToText.Text = "Text";
            this.btnHexToText.UseVisualStyleBackColor = true;
            this.btnHexToText.Click += new System.EventHandler(this.btnHexToText_Click);
            // 
            // btnTextToHex
            // 
            this.btnTextToHex.Location = new System.Drawing.Point(30, 279);
            this.btnTextToHex.Name = "btnTextToHex";
            this.btnTextToHex.Size = new System.Drawing.Size(101, 31);
            this.btnTextToHex.TabIndex = 11;
            this.btnTextToHex.Text = "Hex";
            this.btnTextToHex.UseVisualStyleBackColor = true;
            this.btnTextToHex.Click += new System.EventHandler(this.btnTextToHex_Click);
            // 
            // rtxtHexData
            // 
            this.rtxtHexData.Location = new System.Drawing.Point(8, 25);
            this.rtxtHexData.Name = "rtxtHexData";
            this.rtxtHexData.ReadOnly = true;
            this.rtxtHexData.Size = new System.Drawing.Size(536, 248);
            this.rtxtHexData.TabIndex = 10;
            this.rtxtHexData.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Thanh tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Địa chỉ IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Giao diện kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(181, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(971, 26);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbNetworkInterface
            // 
            this.cmbNetworkInterface.FormattingEnabled = true;
            this.cmbNetworkInterface.Location = new System.Drawing.Point(232, 13);
            this.cmbNetworkInterface.Name = "cmbNetworkInterface";
            this.cmbNetworkInterface.Size = new System.Drawing.Size(261, 28);
            this.cmbNetworkInterface.TabIndex = 28;
            this.cmbNetworkInterface.SelectedIndexChanged += new System.EventHandler(this.cmbNetworkInterface_SelectedIndexChanged);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(181, 54);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = true;
            this.txtIPAddress.Size = new System.Drawing.Size(257, 26);
            this.txtIPAddress.TabIndex = 27;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(791, 8);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(155, 72);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(594, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 72);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // treeViewPacketDetails
            // 
            this.treeViewPacketDetails.Location = new System.Drawing.Point(9, 531);
            this.treeViewPacketDetails.Name = "treeViewPacketDetails";
            this.treeViewPacketDetails.Size = new System.Drawing.Size(583, 310);
            this.treeViewPacketDetails.TabIndex = 24;
            // 
            // listViewPackets
            // 
            this.listViewPackets.HideSelection = false;
            this.listViewPackets.Location = new System.Drawing.Point(9, 145);
            this.listViewPackets.Name = "listViewPackets";
            this.listViewPackets.Size = new System.Drawing.Size(1143, 380);
            this.listViewPackets.TabIndex = 23;
            this.listViewPackets.UseCompatibleStateImageBehavior = false;
            this.listViewPackets.SelectedIndexChanged += new System.EventHandler(this.listViewPackets_SelectedIndexChanged);
            // 
            // NetworkSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 849);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbNetworkInterface);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.treeViewPacketDetails);
            this.Controls.Add(this.listViewPackets);
            this.Name = "NetworkSniffer";
            this.Text = "NetworkSniffer";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHexToText;
        private System.Windows.Forms.Button btnTextToHex;
        private System.Windows.Forms.RichTextBox rtxtHexData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbNetworkInterface;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TreeView treeViewPacketDetails;
        private System.Windows.Forms.ListView listViewPackets;
    }
}