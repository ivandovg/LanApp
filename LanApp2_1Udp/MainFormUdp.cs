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
using System.Net.Sockets;

namespace LanApp2_1Udp
{
    public partial class MainFormUdp : Form
    {
        // сокет для приема сообщений
        private Socket listeningSocket = null;
        // порт для отправки
        private int localPort;
        // порт для чтения
        private int remotePort;
        // адрес для отправки
        private IPEndPoint remoteAddress;

        private Task listenTask;
        public MainFormUdp()
        {
            InitializeComponent();
        }

        private void btnStartReceive_Click(object sender, EventArgs e)
        {
            if (listeningSocket != null)
                return;

            try
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                localPort = (int)edlocalPort.Value;
                remotePort = (int)edRemotePort.Value;
                remoteAddress = new IPEndPoint(IPAddress.Parse(edRemoteAddress.Text), remotePort);

                // запуск получения сообщений
                listenTask = Task.Run(Listen);

                grConnection.Enabled = false;
                grSendMessage.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listen()
        {
            // получение сообщений
            IPEndPoint localEndPoint=new IPEndPoint(IPAddress.Any, localPort);
            listeningSocket.Bind(localEndPoint);

            StringBuilder builder = new StringBuilder();
            int len = 0;
            byte[] data = new byte[64];

            while (true)
            {
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                do
                {
                    len = listeningSocket.ReceiveFrom(data, ref remoteEndPoint);
                    builder.Append(Encoding.UTF8.GetString(data, 0, len));
                } while (listeningSocket.Available > 0);

                IPEndPoint remoteIp = (IPEndPoint)remoteEndPoint;

                Action action = () =>
                {
                    lsMessages.Items.Insert(0, $"{remoteIp.Address}>> {builder}");
                };
                Invoke(action);

                builder.Clear();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // отправка сообщений
            if (listeningSocket == null || string.IsNullOrEmpty(edMessage.Text))
                return;

            byte[] data = Encoding.UTF8.GetBytes(edMessage.Text);
            listeningSocket.SendTo(data, remoteAddress);
            lsMessages.Items.Insert(0, "me>>" + edMessage.Text);
            edMessage.Focus();
            edMessage.SelectAll();
        }
    }
}
