using System.Net.Sockets;
using System.Text;

namespace Tcp_private
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream clientStream;
        private Thread clientThread;
        public ClientForm()
        {
            InitializeComponent();
        }
        private void ConnectToServer()
        {
            client = new TcpClient("127.0.0.1", 5000);
            clientStream = client.GetStream();

            string username = textBoxUsername.Text;
            byte[] usernameBytes = Encoding.UTF8.GetBytes(username);
            clientStream.Write(usernameBytes, 0, usernameBytes.Length);
            clientStream.Flush();
            clientThread = new Thread(ListenForMessages);
            clientThread.Start();
            UpdateLog("Connected to server...");
        }
        private bool shouldStopClient = false;

        private void ListenForMessages()
        {
            byte[] message = new byte[4096];
            int bytesRead;

            while (!shouldStopClient)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    break;
                }

                string msg = Encoding.UTF8.GetString(message, 0, bytesRead);
                UpdateLog(msg);
            }
            clientThread.Abort();
        }

        private void SendMessage(string message)
        {
            string recipientUsername = textBoxRecipient.Text;
            string sender = textBoxUsername.Text; 
            string formattedMessage = recipientUsername + ":" + sender + ":" + message ;
            byte[] buffer = Encoding.UTF8.GetBytes(formattedMessage);
            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            textBoxMessage.Clear();
        }

        private void UpdateLog(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateLog), new object[] { message });
                return;
            }

            textBoxLog.AppendText(message + Environment.NewLine);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            textBoxLog.AppendText(username + ": " + textBoxMessage.Text + Environment.NewLine);
            SendMessage(textBoxMessage.Text);
            textBoxMessage.Clear();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }
        private void Stop_Btt_Click(object sender, EventArgs e)
        {
            shouldStopClient = true;
            client.Close();
        }
       
    }
}
