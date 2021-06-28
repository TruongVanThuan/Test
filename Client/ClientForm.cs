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

namespace Client
{
  
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            buttonSend.Enabled = false;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            textboxStatus.Invoke((MethodInvoker)delegate ()
            {
                string str = e.MessageString;
                string str_final = str.Substring(0, str.Length - 1);
                textboxStatus.Text += str_final;
            });
            buttonSend.Invoke((MethodInvoker)delegate ()
            {
                buttonSend.Enabled = true;

            });


        }

        SimpleTcpClient client;

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            
            try
            {
                client.Connect(textboxHost.Text, Convert.ToInt32(textportPort.Text));
                buttonSend.Enabled = true;
            }
            catch (Exception)
            {

                textboxStatus.Text = "Bạn chọn sai Host rồi nhé <3";
                buttonConnect.Enabled = true;
            }


        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            buttonSend.Enabled = false;         
            client.WriteLineAndGetReply(textboxMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
