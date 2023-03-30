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
using System.IO;

namespace LanApp6_1Multicast
{
    public partial class MainFormMulticast : Form
    {
        private UdpClient receiverUdp;
        private UdpClient senderUdp;
        private IPEndPoint senderIp;

        public MainFormMulticast()
        {
            receiverUdp = senderUdp = null;
            InitializeComponent();
        }

        private void SetLockState(bool isLock)
        {
            grConnection.Enabled = !isLock;
            btnConnect.Enabled = !isLock;

            grSendMessage.Enabled = isLock;
            btnDisconnect.Enabled = isLock;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsMessages.Items.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (senderUdp != null)
                return;


            senderIp = new IPEndPoint(IPAddress.Parse(edRemoteAddress.Text), (int)edRemotePort.Value);
            senderUdp = new UdpClient();

            SetLockState(true);

            //Task.Run(() => ReceiveMessage(edRemoteAddress.Text, (int)edRemotePort.Value));
            ReceiveMessageAsync(edRemoteAddress.Text, (int)edRemotePort.Value);
        }

        private async void ReceiveMessageAsync(string ip, int port)
        {
            try
            {
                receiverUdp = new UdpClient(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error in receive message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 224.0.0.0 - 239.255.255.255
            receiverUdp.JoinMulticastGroup(IPAddress.Parse(ip), 20);

            try
            {
                //StringBuilder builder = new StringBuilder();
                MessagePacket packet = null;

                while (true)
                {
                    //do
                    //{
                    //    var result = await receiverUdp.ReceiveAsync();
                    //    //builder.Append(Encoding.UTF8.GetString(result.Buffer));
                    //    packet = MessagePacket.FromByteArray(result.Buffer);
                    //} while (receiverUdp.Available > 0);

                    MemoryStream ms = new MemoryStream();
                    do
                    {
                        var result = await receiverUdp.ReceiveAsync();
                        ms.Write(result.Buffer, 0, result.Buffer.Length);
                    } while (receiverUdp.Available > 0);
                    ms.Position = 0;
                    packet = MessagePacket.FromStream(ms);

                    switch (packet.Type)
                    {
                        case MessageType.None:
                            lsMessages.Items.Insert(0, "None>>" + packet);
                            break;
                        case MessageType.Text:
                            lsMessages.Items.Insert(0, "Text>>"+packet);
                            break;
                        case MessageType.File:
                            lsMessages.Items.Insert(0, "File>>" + packet);
                            break;
                        case MessageType.Image:
                            lsMessages.Items.Insert(0, "Image>>" + packet);
                            break;
                        default:
                            lsMessages.Items.Insert(0, "Unknown type >>" + packet);
                            break;
                    }

                    //builder.Clear();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(this, ex.Message, "Error in receive message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveMessage(string ip, int port)
        {
            try
            {
                receiverUdp = new UdpClient(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error in receive messare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 224.0.0.0 - 239.255.255.255
            receiverUdp.JoinMulticastGroup(IPAddress.Parse(ip), 20);
            IPEndPoint remoteIp = null;

            try
            {
                byte[] data;
                StringBuilder builder = new StringBuilder();

                while (true)
                {
                    do
                    {
                        data = receiverUdp.Receive(ref remoteIp);
                        builder.Append(Encoding.UTF8.GetString(data));
                    } while (receiverUdp.Available > 0);
                    Action action = () =>
                    {
                        lsMessages.Items.Insert(0, $"{remoteIp} >> {builder}");
                    };
                    Invoke(action);
                    builder.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error in receive messare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                btnSend.Enabled = false;
                //byte[] data = Encoding.UTF8.GetBytes($"{edUsername.Text}: {edMessage.Text}");
                MessagePacket packet = new MessagePacket()
                {
                    Type = MessageType.Text,
                    Data = $"{edUsername.Text}: {edMessage.Text}"
                };
                byte[] data = packet.ToByteArray();

                senderUdp.Send(data, data.Length, senderIp);
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                senderUdp.Close();
                receiverUdp.Close();
            }
            finally
            {
                senderUdp = null;
                receiverUdp = null;
                SetLockState(false);
            }
        }

        private static string LocalIPAddress()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

    }
}
