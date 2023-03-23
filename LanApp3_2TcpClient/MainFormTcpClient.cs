using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace LanApp3_2TcpClient
{
    public partial class MainFormTcpClient : Form
    {
        TcpConnection connection;
        public MainFormTcpClient()
        {
            InitializeComponent();
            connection = null;
            FormClosing += MainFormTcpClient_FormClosing;
        }

        private void MainFormTcpClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null)
                connection.Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new TcpConnection(IPAddress.Parse(edRemoteAddress.Text), (int)edRemotePort.Value);
                connection.Connect();
                ChangeConnectionState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Disconnect();
            }
            finally
            {
                ChangeConnectionState(false);
            }
        }

        private void ChangeConnectionState(bool connected = true)
        {
            grConnection.Enabled = !connected;
            grSendMessage.Enabled = connected;
            btnConnect.Enabled = !connected;
            btnDisconnect.Enabled = connected;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsMessages.Items.Clear();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            lsMessages.Items.Insert(0, "me >> " + edMessage.Text);
            connection.SendMessage(edMessage.Text);
            string message = await connection.ReceiveMessage();
            lsMessages.Items.Insert(0, "server >> " + message);
        }
    }
}
