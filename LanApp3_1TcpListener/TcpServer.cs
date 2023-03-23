using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace LanApp3_1TcpListener
{
    internal class TcpServer
    {
        private TcpListener listener;
        private IPAddress address;
        private int port;

        public delegate void StringMessageDelegate(string message);

        public event StringMessageDelegate StringMessage;

        // список подключенных клиентов
        private List<TcpClientConnection> clientConnections;
        public TcpServer(IPAddress address, int port)
        {
            this.address = address;
            this.port = port;
            listener = null;
            clientConnections = null;
        }

        public Task StartListenAsync() => Task.Run(StartListen);

        public async void StartListen()
        {
            if (listener != null)
            {
                return;
            }
            listener = new TcpListener(address, port);
            clientConnections = new List<TcpClientConnection>();

            // запуск прослушивания
            listener.Start();
            StringMessage?.Invoke("Start server! Accept connections...");
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                //await Console.Out.WriteLineAsync("Accept connection: " + client.Client.RemoteEndPoint);
                StringMessage?.Invoke("Accept connection: " + client.Client.RemoteEndPoint);

                TcpClientConnection clientConnection = new TcpClientConnection(client);
                clientConnections.Add(clientConnection);
                clientConnection.MessageText += ClientConnection_MessageText;
                clientConnection.ConnecctedStateChange += ClientConnection_ConnecctedStateChange;
                _ = clientConnection.StartMessagingAsync();
            }
        }

        private void ClientConnection_ConnecctedStateChange(TcpClientConnection clientConnection, bool isConnected)
        {
            if (isConnected)
            {
                StringMessage?.Invoke($"Client {clientConnection.Address} is connected!");
            }
            else
            {
                StringMessage?.Invoke($"Client {clientConnection.Address} is disconnected!");
                clientConnections.Remove(clientConnection);
            }
        }

        private void ClientConnection_MessageText(TcpClientConnection clientConnection, string message)
        {
            StringMessage?.Invoke($"{clientConnection.Address} >> {message}");
        }

        public void StopListen()
        {
            if (listener != null)
            {
                if(clientConnections != null)
                {
                    // например: информировать всех что сервер будет остановлен
                    // очистить список подключений
                    clientConnections.Clear();
                }
                listener.Stop();
                listener = null;
                StringMessage?.Invoke("Stop server!");
            }
        }
    }
}
