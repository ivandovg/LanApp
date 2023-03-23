using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LanApp3_2TcpClient
{
    internal class TcpConnection
    {
        private readonly TcpClient client;
        private IPAddress address;
        private int port;

        public TcpConnection(IPAddress address, int port)
        {
            client = new TcpClient();
            this.address = address;
            this.port = port;
        }

        public void Connect()
        {
            client.Connect(address, port);
        }

        public void Disconnect()
        {
            SendMessage("exit");
            Thread.Sleep(1000);
            client.Close();
        }
        public async void SendMessage(string message)
        {
            await SendString(message, client.GetStream());
        }

        public async Task<string> ReceiveMessage()
        {
            return await ReceiveString(client.GetStream());
        }
        private async Task SendString(string message, NetworkStream ns)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await ns.WriteAsync(data, 0, data.Length);
        }

        private async Task<string> ReceiveString(NetworkStream ns)
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];
            do
            {
                bytes = await ns.ReadAsync(data, 0, data.Length);
                builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
            } while (ns.DataAvailable);

            return builder.ToString();
        }
    }
}
