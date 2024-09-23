namespace Lab1_bai1
{
    partial class Form1
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
            Ten1 = new Label();
            tBnhap1 = new TextBox();
            Ten2 = new Label();
            tBnhap2 = new TextBox();
            Ten3 = new Label();
            tBnhap3 = new TextBox();
            timBtt = new Button();
            xoaBtt = new Button();
            escBtt = new Button();
            output1 = new Label();
            tBxuat1 = new TextBox();
            output2 = new Label();
            tBxuat2 = new TextBox();
            SuspendLayout();
            // 
            // Ten1
            // 
            Ten1.AutoSize = true;
            Ten1.Location = new Point(32, 99);
            Ten1.Name = "Ten1";
            Ten1.Size = new Size(85, 20);
            Ten1.TabIndex = 0;
            Ten1.Text = "Số thứ nhất";
            // 
            // tBnhap1
            // 
            tBnhap1.Location = new Point(123, 92);
            tBnhap1.Name = "tBnhap1";
            tBnhap1.PlaceholderText = "0";
            tBnhap1.Size = new Size(125, 27);
            tBnhap1.TabIndex = 1;
            // 
            // Ten2
            // 
            Ten2.AutoSize = true;
            Ten2.Location = new Point(277, 99);
            Ten2.Name = "Ten2";
            Ten2.Size = new Size(76, 20);
            Ten2.TabIndex = 0;
            Ten2.Text = "Số thứ hai";
            // 
            // tBnhap2
            // 
            tBnhap2.Location = new Point(363, 92);
            tBnhap2.Name = "tBnhap2";
            tBnhap2.PlaceholderText = "0";
            tBnhap2.Size = new Size(125, 27);
            tBnhap2.TabIndex = 1;
            // 
            // Ten3
            // 
            Ten3.AutoSize = true;
            Ten3.Location = new Point(521, 99);
            Ten3.Name = "Ten3";
            Ten3.Size = new Size(73, 20);
            Ten3.TabIndex = 0;
            Ten3.Text = "Số thứ ba";
            // 
            // tBnhap3
            // 
            tBnhap3.Location = new Point(600, 92);
            tBnhap3.Name = "tBnhap3";
            tBnhap3.PlaceholderText = "0";
            tBnhap3.Size = new Size(125, 27);
            tBnhap3.TabIndex = 1;
            // 
            // timBtt
            // 
            timBtt.BackColor = Color.DeepSkyBlue;
            timBtt.Location = new Point(123, 210);
            timBtt.Name = "timBtt";
            timBtt.Size = new Size(110, 35);
            timBtt.TabIndex = 2;
            timBtt.Text = "Tìm";
            timBtt.UseVisualStyleBackColor = false;
            timBtt.Click += timBtt_Click;
            // 
            // xoaBtt
            // 
            xoaBtt.BackColor = Color.DeepSkyBlue;
            xoaBtt.Location = new Point(363, 210);
            xoaBtt.Name = "xoaBtt";
            xoaBtt.Size = new Size(110, 35);
            xoaBtt.TabIndex = 2;
            xoaBtt.Text = "Xóa";
            xoaBtt.UseVisualStyleBackColor = false;
            xoaBtt.Click += xoaBtt_Click;
            // 
            // escBtt
            // 
            escBtt.BackColor = Color.DeepSkyBlue;
            escBtt.Location = new Point(600, 210);
            escBtt.Name = "escBtt";
            escBtt.Size = new Size(110, 35);
            escBtt.TabIndex = 2;
            escBtt.Text = "Thoát";
            escBtt.UseVisualStyleBackColor = false;
            escBtt.Click += escBtt_Click;
            // 
            // output1
            // 
            output1.AutoSize = true;
            output1.Location = new Point(123, 374);
            output1.Name = "output1";
            output1.Size = new Size(90, 20);
            output1.TabIndex = 0;
            output1.Text = "Số Lớn Nhất";
            // 
            // tBxuat1
            // 
            tBxuat1.BackColor = SystemColors.MenuBar;
            tBxuat1.Location = new Point(219, 374);
            tBxuat1.Name = "tBxuat1";
            tBxuat1.ReadOnly = true;
            tBxuat1.Size = new Size(125, 27);
            tBxuat1.TabIndex = 1;
            // 
            // output2
            // 
            output2.AutoSize = true;
            output2.Location = new Point(430, 374);
            output2.Name = "output2";
            output2.Size = new Size(94, 20);
            output2.TabIndex = 0;
            output2.Text = "Số Nhỏ Nhất";
            // 
            // tBxuat2
            // 
            tBxuat2.BackColor = SystemColors.MenuBar;
            tBxuat2.Location = new Point(521, 374);
            tBxuat2.Name = "tBxuat2";
            tBxuat2.ReadOnly = true;
            tBxuat2.Size = new Size(125, 27);
            tBxuat2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(782, 403);
            Controls.Add(escBtt);
            Controls.Add(xoaBtt);
            Controls.Add(timBtt);
            Controls.Add(tBnhap3);
            Controls.Add(Ten3);
            Controls.Add(tBnhap2);
            Controls.Add(Ten2);
            Controls.Add(tBxuat2);
            Controls.Add(tBxuat1);
            Controls.Add(output2);
            Controls.Add(tBnhap1);
            Controls.Add(output1);
            Controls.Add(Ten1);
            Name = "Form1";
            Text = "BaiTH1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ten1;
        private TextBox tBnhap1;
        private Label Ten2;
        private TextBox tBnhap2;
        private Label Ten3;
        private TextBox tBnhap3;
        private Button timBtt;
        private Button xoaBtt;
        private Button escBtt;
        private Label output1;
        private TextBox tBxuat1;
        private Label output2;
        private TextBox tBxuat2;
    }
}
