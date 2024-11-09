using System.Drawing;
using System.Windows.Forms;

namespace LastNetworkSniffer
{
    partial class Sniffer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPackets = new System.Windows.Forms.ListView();
            this.comboBoxInterfaces = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDetails = new System.Windows.Forms.RichTextBox();
            this.StopBtt = new System.Windows.Forms.Button();
            this.SaveBtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewPacketDetails = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listViewPackets
            // 
            this.listViewPackets.BackColor = System.Drawing.Color.Bisque;
            this.listViewPackets.FullRowSelect = true;
            this.listViewPackets.HideSelection = false;
            this.listViewPackets.Location = new System.Drawing.Point(21, 110);
            this.listViewPackets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPackets.Name = "listViewPackets";
            this.listViewPackets.Size = new System.Drawing.Size(977, 303);
            this.listViewPackets.TabIndex = 0;
            this.listViewPackets.UseCompatibleStateImageBehavior = false;
            this.listViewPackets.View = System.Windows.Forms.View.Details;
            this.listViewPackets.SelectedIndexChanged += new System.EventHandler(this.listViewPackets_SelectedIndexChanged);
            // 
            // comboBoxInterfaces
            // 
            this.comboBoxInterfaces.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInterfaces.FormattingEnabled = true;
            this.comboBoxInterfaces.Location = new System.Drawing.Point(211, 45);
            this.comboBoxInterfaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInterfaces.Name = "comboBoxInterfaces";
            this.comboBoxInterfaces.Size = new System.Drawing.Size(394, 28);
            this.comboBoxInterfaces.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartCapture_Click);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.Color.OldLace;
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.Location = new System.Drawing.Point(569, 417);
            this.textBoxDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(429, 199);
            this.textBoxDetails.TabIndex = 3;
            this.textBoxDetails.Text = "";
            // 
            // StopBtt
            // 
            this.StopBtt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.StopBtt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtt.Location = new System.Drawing.Point(882, 27);
            this.StopBtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopBtt.Name = "StopBtt";
            this.StopBtt.Size = new System.Drawing.Size(116, 59);
            this.StopBtt.TabIndex = 2;
            this.StopBtt.Text = "Dừng";
            this.StopBtt.UseVisualStyleBackColor = false;
            this.StopBtt.Click += new System.EventHandler(this.StopCapture_Click);
            // 
            // SaveBtt
            // 
            this.SaveBtt.BackColor = System.Drawing.Color.LightSalmon;
            this.SaveBtt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtt.Location = new System.Drawing.Point(643, 27);
            this.SaveBtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtt.Name = "SaveBtt";
            this.SaveBtt.Size = new System.Drawing.Size(114, 53);
            this.SaveBtt.TabIndex = 2;
            this.SaveBtt.Text = "Lưu file";
            this.SaveBtt.UseVisualStyleBackColor = false;
            this.SaveBtt.Click += new System.EventHandler(this.SaveCapture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn giao diện mạng";
            // 
            // treeViewPacketDetails
            // 
            this.treeViewPacketDetails.Location = new System.Drawing.Point(21, 418);
            this.treeViewPacketDetails.Name = "treeViewPacketDetails";
            this.treeViewPacketDetails.Size = new System.Drawing.Size(542, 204);
            this.treeViewPacketDetails.TabIndex = 5;
            // 
            // Sniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 634);
            this.Controls.Add(this.treeViewPacketDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.SaveBtt);
            this.Controls.Add(this.StopBtt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxInterfaces);
            this.Controls.Add(this.listViewPackets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sniffer";
            this.Text = "Network sniffer";
            this.Load += new System.EventHandler(this.Sniffer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewPackets;
        private ComboBox comboBoxInterfaces;
        private Button button1;
        private RichTextBox textBoxDetails;
        private Button StopBtt;
        private Button SaveBtt;
        private Label label1;
        private TreeView treeViewPacketDetails;
    }
}
