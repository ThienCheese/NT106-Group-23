namespace Tcp_private
{
    partial class ClientForm
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
            textBoxLog = new RichTextBox();
            textBoxMessage = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBoxUsername = new TextBox();
            textBoxRecipient = new TextBox();
            Stop_Btt = new Button();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(42, 92);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(599, 263);
            textBoxLog.TabIndex = 0;
            textBoxLog.Text = "";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(42, 398);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(599, 27);
            textBoxMessage.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(679, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonConnect_Click;
            // 
            // button2
            // 
            button2.Location = new Point(665, 384);
            button2.Name = "button2";
            button2.Size = new Size(108, 54);
            button2.TabIndex = 2;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSend_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(42, 12);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Enter a username";
            textBoxUsername.Size = new Size(261, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(42, 57);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.PlaceholderText = "Enter your target";
            textBoxRecipient.Size = new Size(261, 27);
            textBoxRecipient.TabIndex = 3;
            // 
            // Stop_Btt
            // 
            Stop_Btt.Location = new Point(679, 58);
            Stop_Btt.Name = "Stop_Btt";
            Stop_Btt.Size = new Size(94, 29);
            Stop_Btt.TabIndex = 2;
            Stop_Btt.Text = "Stop";
            Stop_Btt.UseVisualStyleBackColor = true;
            Stop_Btt.Click += Stop_Btt_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRecipient);
            Controls.Add(textBoxUsername);
            Controls.Add(button2);
            Controls.Add(Stop_Btt);
            Controls.Add(button1);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxLog);
            Name = "ClientForm";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBoxLog;
        private TextBox textBoxMessage;
        private Button button1;
        private Button button2;
        private TextBox textBoxUsername;
        private TextBox textBoxRecipient;
        private Button Stop_Btt;
    }
}
