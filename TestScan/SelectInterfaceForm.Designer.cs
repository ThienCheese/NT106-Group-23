namespace TestScan
{
    partial class SelectInterfaceForm
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.comboBoxNetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.comboBoxIPAddresses = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(161, 220);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 111);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // comboBoxNetworkInterfaces
            // 
            this.comboBoxNetworkInterfaces.FormattingEnabled = true;
            this.comboBoxNetworkInterfaces.Location = new System.Drawing.Point(300, 69);
            this.comboBoxNetworkInterfaces.Name = "comboBoxNetworkInterfaces";
            this.comboBoxNetworkInterfaces.Size = new System.Drawing.Size(261, 28);
            this.comboBoxNetworkInterfaces.TabIndex = 1;
            this.comboBoxNetworkInterfaces.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetworkInterfaces_SelectedIndexChanged_1);
            // 
            // comboBoxIPAddresses
            // 
            this.comboBoxIPAddresses.FormattingEnabled = true;
            this.comboBoxIPAddresses.Location = new System.Drawing.Point(300, 144);
            this.comboBoxIPAddresses.Name = "comboBoxIPAddresses";
            this.comboBoxIPAddresses.Size = new System.Drawing.Size(261, 28);
            this.comboBoxIPAddresses.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(501, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 111);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn giao diện mạng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn địa chỉ IP mục tiêu:";
            // 
            // SelectInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxIPAddresses);
            this.Controls.Add(this.comboBoxNetworkInterfaces);
            this.Controls.Add(this.btnSelect);
            this.Name = "SelectInterfaceForm";
            this.Text = "SelectInterfaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox comboBoxNetworkInterfaces;
        private System.Windows.Forms.ComboBox comboBoxIPAddresses;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}