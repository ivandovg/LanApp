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
            
            Console.WriteLine("Press enter key to stop server");
            Console.ReadLine();
        }
    }

    internal class MyServer
    {
        private int port;
        private IPAddress ip;
        public MyServer(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }
        public void StartServer()
        {
            // прием и обработка подключений
            // создание сокета
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
                server.BeginAccept(AcceptCallback, server);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERR: " + ex.Message);
            }
        }

        public void AcceptCallback(IAsyncResult result)
        {
            // завершаем прием подключения
            Socket server = result.AsyncState as Socket;
            if (server == null)
            {
                Console.WriteLine("Is not a Socket!");
                Console.ReadLine();
                return;
            }

            Socket client = server.EndAccept(result);
            ClientConnection clientConnection = new ClientConnection(client);
            clientConnection.StartMessagingAsync();
            
            // прием подключений
            server.BeginAccept(AcceptCallback, server);
        }
    }
}
