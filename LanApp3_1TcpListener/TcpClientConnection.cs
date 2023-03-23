using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace LanApp3_1TcpListener
{
    internal class TcpClientConnection
    {
        private static int clientConnectionCount = 0;
        private int clientId;
        public int ClientId { get => clientId; }

        private TcpClient client;
        public IPEndPoint Address { get; private set; }

        public delegate void MessageDelegate(TcpClientConnection clientConnection, string message);
        public delegate void ConnecctedDelegate(TcpClientConnection clientConnection, bool isConnected);

        public event MessageDelegate MessageText;
        public event ConnecctedDelegate ConnecctedStateChange;

        public TcpClientConnection(TcpClient client)
        {
            if (client == null)
                throw new ArgumentNullException();
            this.client = client;
            clientId = ++clientConnectionCount;
            Address = client.Client.RemoteEndPoint as IPEndPoint;
            ConnecctedStateChange?.Invoke(this, true);
        }

        public async void StartMessaging()
        {
            NetworkStream ns = client.GetStream();

            await SendString("Hello User!", ns);

            while (true)
            {
                string query = await ReceiveString(ns);
                MessageText(this, query);
                if (query.ToLower().Equals("exit"))
                {
                    await SendString("Goodbye!!!", ns);
                    break;
                }
                else
                    await SendString("Your message delivered!", ns);
            }
            client.Close();
            ConnecctedStateChange(this, false);
        }

        public Task StartMessagingAsync() => Task.Run(StartMessaging);

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
