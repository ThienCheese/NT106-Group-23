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
            this.saveBtt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHexToText);
            this.groupBox1.Controls.Add(this.btnTextToHex);
            this.groupBox1.Controls.Add(this.rtxtHexData);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(532, 425);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 317);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload";
            // 
            // btnHexToText
            // 
            this.btnHexToText.BackColor = System.Drawing.Color.Coral;
            this.btnHexToText.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexToText.Location = new System.Drawing.Point(103, 274);
            this.btnHexToText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHexToText.Name = "btnHexToText";
            this.btnHexToText.Size = new System.Drawing.Size(90, 39);
            this.btnHexToText.TabIndex = 12;
            this.btnHexToText.Text = "Text";
            this.btnHexToText.UseVisualStyleBackColor = false;
            this.btnHexToText.Click += new System.EventHandler(this.btnHexToText_Click);
            // 
            // btnTextToHex
            // 
            this.btnTextToHex.BackColor = System.Drawing.Color.LightCoral;
            this.btnTextToHex.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextToHex.Location = new System.Drawing.Point(7, 274);
            this.btnTextToHex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextToHex.Name = "btnTextToHex";
            this.btnTextToHex.Size = new System.Drawing.Size(90, 39);
            this.btnTextToHex.TabIndex = 11;
            this.btnTextToHex.Text = "Hex";
            this.btnTextToHex.UseVisualStyleBackColor = false;
            this.btnTextToHex.Click += new System.EventHandler(this.btnTextToHex_Click);
            // 
            // rtxtHexData
            // 
            this.rtxtHexData.BackColor = System.Drawing.Color.PeachPuff;
            this.rtxtHexData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtHexData.Location = new System.Drawing.Point(7, 20);
            this.rtxtHexData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtHexData.Name = "rtxtHexData";
            this.rtxtHexData.ReadOnly = true;
            this.rtxtHexData.Size = new System.Drawing.Size(431, 250);
            this.rtxtHexData.TabIndex = 10;
            this.rtxtHexData.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Thanh tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Địa chỉ IP ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chọn giao diện";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(199, 79);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 22);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbNetworkInterface
            // 
            this.cmbNetworkInterface.FormattingEnabled = true;
            this.cmbNetworkInterface.Location = new System.Drawing.Point(199, 10);
            this.cmbNetworkInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNetworkInterface.Name = "cmbNetworkInterface";
            this.cmbNetworkInterface.Size = new System.Drawing.Size(286, 24);
            this.cmbNetworkInterface.TabIndex = 28;
            this.cmbNetworkInterface.SelectedIndexChanged += new System.EventHandler(this.cmbNetworkInterface_SelectedIndexChanged);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(199, 46);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = true;
            this.txtIPAddress.Size = new System.Drawing.Size(286, 22);
            this.txtIPAddress.TabIndex = 27;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStop.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(769, 28);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 58);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Cyan;
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(654, 30);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 56);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // treeViewPacketDetails
            // 
            this.treeViewPacketDetails.BackColor = System.Drawing.Color.PeachPuff;
            this.treeViewPacketDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewPacketDetails.Location = new System.Drawing.Point(8, 425);
            this.treeViewPacketDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewPacketDetails.Name = "treeViewPacketDetails";
            this.treeViewPacketDetails.Size = new System.Drawing.Size(519, 317);
            this.treeViewPacketDetails.TabIndex = 24;
            // 
            // listViewPackets
            // 
            this.listViewPackets.BackColor = System.Drawing.Color.Bisque;
            this.listViewPackets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPackets.HideSelection = false;
            this.listViewPackets.Location = new System.Drawing.Point(8, 116);
            this.listViewPackets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPackets.Name = "listViewPackets";
            this.listViewPackets.Size = new System.Drawing.Size(969, 305);
            this.listViewPackets.TabIndex = 23;
            this.listViewPackets.UseCompatibleStateImageBehavior = false;
            this.listViewPackets.SelectedIndexChanged += new System.EventHandler(this.listViewPackets_SelectedIndexChanged);
            // 
            // saveBtt
            // 
            this.saveBtt.BackColor = System.Drawing.Color.Salmon;
            this.saveBtt.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtt.Location = new System.Drawing.Point(891, 30);
            this.saveBtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtt.Name = "saveBtt";
            this.saveBtt.Size = new System.Drawing.Size(79, 56);
            this.saveBtt.TabIndex = 26;
            this.saveBtt.Text = "Lưu";
            this.saveBtt.UseVisualStyleBackColor = false;
            this.saveBtt.Click += new System.EventHandler(this.saveBtt_Click);
            // 
            // NetworkSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbNetworkInterface);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.saveBtt);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.treeViewPacketDetails);
            this.Controls.Add(this.listViewPackets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button saveBtt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}