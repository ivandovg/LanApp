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
            senderIp = null;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsMessages.Items.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (senderUdp != null)
                return;

            Task.Run(() => ReceiveMessage(edRemoteAddress.Text, (int)edRemotePort.Value));

            senderUdp = new UdpClient();
            senderIp = new IPEndPoint(IPAddress.Parse(edRemoteAddress.Text), (int)edRemotePort.Value);
        }

        private void ReceiveMessage(string ip, int port)
        {
            receiverUdp = new UdpClient(port);
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
            byte[] data = Encoding.UTF8.GetBytes($"{edUsername.Text}: {edMessage.Text}");
            senderUdp.Send(data, data.Length, senderIp);
        }
    }
}
