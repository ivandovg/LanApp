using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace LanApp4_1UdpClient
{
    public partial class MainForm : Form
    {
        private UdpClient client;
        private UdpClient receiver;

        private CancellationTokenSource tokenSource;
        private CancellationToken token;
        public MainForm()
        {
            client = null;
            receiver = null;
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                btnDisconnect_Click(null, null);
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsMessages.Items.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                return;
            }

            client = new UdpClient();
            receiver = new UdpClient((int)edLocalPort.Value);

            grSendMessage.Enabled = true;
            btnDisconnect.Enabled = true;
            btnConnect.Enabled = false;

            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;

            Task task = Task.Run(ReceiveMessages, token);
        }
        private void ReceiveMessages()
        {
            IPEndPoint remotePoint = null;

            StringBuilder builder = new StringBuilder();
            try
            {
                // получение сообщений
                while (true)
                {
                    if (token.IsCancellationRequested)
                        break;

                    do
                    {
                        byte[] data = receiver.Receive(ref remotePoint);
                        builder.Append(Encoding.UTF8.GetString(data));
                    } while (receiver.Available>0);
                    Action action = () =>
                    {
                        lsMessages.Items.Insert(0, $"{remotePoint.Address} >> {builder}");
                    };
                    Invoke(action);
                    builder.Clear();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                receiver = null;
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                return;
            }

            try
            {
                client.Close();
                tokenSource.Cancel();

                receiver.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                client = null;
                receiver = null;
                grSendMessage.Enabled = false;
                tokenSource.Dispose();
                tokenSource = null;

                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
            }
        }

        private byte[] bytesSend = null;
        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                btnSend.Enabled = false;

                bytesSend = Encoding.UTF8.GetBytes(edMessage.Text);
                await client.SendAsync(bytesSend, bytesSend.Length, 
                    new IPEndPoint(IPAddress.Parse(edRemoteAddress.Text), (int)edRemotePort.Value));

                lsMessages.Items.Insert(0, "me>> " + edMessage.Text);
                btnSend.Enabled = true;
            }
        }
    }
}
