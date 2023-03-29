using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanApp5_2ScreenClient
{
    public partial class MainFormScreenClient : Form
    {
        public MainFormScreenClient()
        {
            InitializeComponent();
        }

        private void btnGetScreen_Click(object sender, EventArgs e)
        {
            using (TcpClient tcp = new TcpClient())
            {
                tcp.Connect(new IPEndPoint(IPAddress.Parse(edIPAddress.Text), (int)edPort.Value));
                NetworkStream ns = tcp.GetStream();
                pbScreen.Image = Image.FromStream(ns);
            }
        }
    }
}
