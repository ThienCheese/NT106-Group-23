namespace Photostore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            OpenBtt = new Button();
            PrevBtt = new Button();
            counter_rotate = new Button();
            clk_rotate = new Button();
            ZomoutBtt = new Button();
            button1 = new Button();
            zominBtt = new Button();
            NextBtt = new Button();
            CloseBtt = new Button();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.PeachPuff;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 603);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1082, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.PeachPuff;
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Controls.Add(OpenBtt);
            flowLayoutPanel2.Controls.Add(PrevBtt);
            flowLayoutPanel2.Controls.Add(counter_rotate);
            flowLayoutPanel2.Controls.Add(clk_rotate);
            flowLayoutPanel2.Controls.Add(ZomoutBtt);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(zominBtt);
            flowLayoutPanel2.Controls.Add(NextBtt);
            flowLayoutPanel2.Controls.Add(CloseBtt);
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1082, 37);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(3, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 28);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // OpenBtt
            // 
            OpenBtt.BackColor = Color.Salmon;
            OpenBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            OpenBtt.Location = new Point(48, 3);
            OpenBtt.Name = "OpenBtt";
            OpenBtt.Size = new Size(101, 33);
            OpenBtt.TabIndex = 0;
            OpenBtt.Text = "Open";
            OpenBtt.UseVisualStyleBackColor = false;
            OpenBtt.Click += OpenBtt_Click;
            // 
            // PrevBtt
            // 
            PrevBtt.BackColor = Color.Salmon;
            PrevBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            PrevBtt.Location = new Point(155, 3);
            PrevBtt.Name = "PrevBtt";
            PrevBtt.Size = new Size(108, 34);
            PrevBtt.TabIndex = 2;
            PrevBtt.Text = "Prev";
            PrevBtt.UseVisualStyleBackColor = false;
            PrevBtt.Click += PrevBtt_Click;
            // 
            // counter_rotate
            // 
            counter_rotate.BackColor = Color.Salmon;
            counter_rotate.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            counter_rotate.Location = new Point(269, 3);
            counter_rotate.Name = "counter_rotate";
            counter_rotate.Size = new Size(113, 34);
            counter_rotate.TabIndex = 5;
            counter_rotate.Text = "Rotate";
            counter_rotate.UseVisualStyleBackColor = false;
            counter_rotate.Click += button2_Click;
            // 
            // clk_rotate
            // 
            clk_rotate.BackColor = Color.Salmon;
            clk_rotate.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            clk_rotate.Location = new Point(388, 3);
            clk_rotate.Name = "clk_rotate";
            clk_rotate.Size = new Size(104, 34);
            clk_rotate.TabIndex = 4;
            clk_rotate.Text = "Flip ";
            clk_rotate.UseVisualStyleBackColor = false;
            clk_rotate.Click += clk_rotate_Click;
            // 
            // ZomoutBtt
            // 
            ZomoutBtt.BackColor = Color.Salmon;
            ZomoutBtt.Font = new Font("Papyrus", 15F, FontStyle.Italic);
            ZomoutBtt.Location = new Point(498, 3);
            ZomoutBtt.Name = "ZomoutBtt";
            ZomoutBtt.Size = new Size(45, 34);
            ZomoutBtt.TabIndex = 9;
            ZomoutBtt.Text = "-";
            ZomoutBtt.UseVisualStyleBackColor = false;
            ZomoutBtt.Click += ZomoutBtt_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            button1.Location = new Point(549, 3);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 10;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // zominBtt
            // 
            zominBtt.BackColor = Color.Salmon;
            zominBtt.Font = new Font("Papyrus", 15F, FontStyle.Italic);
            zominBtt.Location = new Point(661, 3);
            zominBtt.Name = "zominBtt";
            zominBtt.Size = new Size(46, 34);
            zominBtt.TabIndex = 8;
            zominBtt.Text = "+";
            zominBtt.UseVisualStyleBackColor = false;
            zominBtt.Click += zominBtt_Click;
            // 
            // NextBtt
            // 
            NextBtt.BackColor = Color.Salmon;
            NextBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            NextBtt.Location = new Point(713, 3);
            NextBtt.Name = "NextBtt";
            NextBtt.Size = new Size(104, 34);
            NextBtt.TabIndex = 3;
            NextBtt.Text = "Next";
            NextBtt.UseVisualStyleBackColor = false;
            NextBtt.Click += NextBtt_Click;
            NextBtt.KeyPress += NextBtt_KeyPress;
            // 
            // CloseBtt
            // 
            CloseBtt.BackColor = Color.Salmon;
            CloseBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            CloseBtt.Location = new Point(823, 3);
            CloseBtt.Name = "CloseBtt";
            CloseBtt.Size = new Size(106, 33);
            CloseBtt.TabIndex = 1;
            CloseBtt.Text = "Close";
            CloseBtt.UseVisualStyleBackColor = false;
            CloseBtt.Click += CloseBtt_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(935, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 34);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 566);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1082, 703);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Photostop";
            Load += Form1_Load;
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button OpenBtt;
        private Button CloseBtt;
        private Button PrevBtt;
        private Button NextBtt;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button counter_rotate;
        private Button clk_rotate;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button ZomoutBtt;
        private Button zominBtt;
        private Button button1;
    }
}
