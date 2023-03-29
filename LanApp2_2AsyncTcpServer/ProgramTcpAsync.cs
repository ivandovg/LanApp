using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LanApp2_2AsyncTcpServer
{
    internal class ProgramTcpAsync
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Server(Async)";
            MyServer server = new MyServer(IPAddress.Any, 1000);
            server.StartServer();

            string cmd;
            do
            {
                Console.WriteLine("Enter command 'exit' to stop server, 'list' - view active connections");
                cmd = Console.ReadLine();
                if (cmd == "list")
                    server.PrintClientConnections();

            } while (cmd != "exit");
        }
    }

    internal class MyServer
    {
        private int port;
        private IPAddress ip;
        private Socket server;

        private List<ClientConnection> clients;
        public void PrintClientConnections()
        {
            if (clients == null)
            {
                Console.WriteLine("Server is not running!!!");
            }
            else
            {
                if (clients.Count==0)
                    Console.WriteLine("No Connections!!!");
                else
                {
                    for (int i = 0; i < clients.Count; i++)
                    {
                        Console.WriteLine(clients[i]);
                    }
                }
            }
        }
        public MyServer(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
            server = null;
            clients = null;
        }
        public void StartServer()
        {
            // прием и обработка подключений
            // создание сокета
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clients = new List<ClientConnection>();
            // конечная точка для получения подключений
            IPEndPoint localEndPoint = new IPEndPoint(ip, port);

            try
            {
                //связать конечную точку и сокет
                server.Bind(localEndPoint);

                // прослушивание подключений, 10 мест в очереди подключений
                server.Listen(10);
                Console.WriteLine("Server started, accept connections...");

                // прием подключений
                server.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERR: " + ex.Message);
            }
        }

        public void AcceptCallback(IAsyncResult result)
        {
            //// завершаем прием подключения
            //Socket server = result.AsyncState as Socket;
            if (server == null)
            {
                //Console.WriteLine("Is not a Socket!");
                //Console.ReadLine();
                return;
            }

            Socket client = server.EndAccept(result);
            ClientConnection clientConnection = new ClientConnection(client);
            clients.Add(clientConnection);
            clientConnection.Disconnected += ClientConnection_Disconnected;
            clientConnection.StartMessagingAsync();
            
            // прием подключений
            server.BeginAccept(AcceptCallback, null);
        }

        private void ClientConnection_Disconnected(ClientConnection connection, string ip)
        {
            Console.WriteLine($"Disconected {connection}({ip})");
            clients.Remove(connection);
        }
    }
}
