using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP1
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            textboxStatus.Invoke((MethodInvoker)delegate ()
            {
                string str = e.MessageString;
                string str_final = str.Substring(0, str.Length -1);
                textboxStatus.Text += str_final;
                // e.ReplyLine(string.Format("You said: {0}", e.MessageString));
                e.ReplyLine($"You said: {str_final} ");
            });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textboxStatus.Text += "Server is starting.....";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textboxHost.Text);
            server.Start(ip, Convert.ToInt32(textportPort.Text));
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
