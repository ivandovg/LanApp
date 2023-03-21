using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace LanApp1_2Server
{
    internal class ProgramServer
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Server";
            MyServer server = new MyServer(IPAddress.Parse("127.0.0.1"), 1000);
            Thread thread = new Thread(server.StartServer);
            thread.IsBackground = true;
            thread.Start();

            Console.WriteLine("Press enter key to stop server");
            Console.ReadLine();
            thread.Abort();
        }
    }

    internal class MyServer
    {
        private int port;
        private IPAddress ip;
        private Socket server;
        public MyServer(IPAddress ip, int port) 
        {
            this.ip = ip;
            this.port = port;
            server = null;
        }
        public Task StartServerAsync()
        {
            return Task.Run(StartServer);
        }
        public void StartServer()
        {
            if (server != null)
            {
                return;
            }
            // прием и обработка подключений
            // создание сокета
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // конечная точка для получения подключений
            IPEndPoint localEndPoint = new IPEndPoint(ip, port);

            // ответ для клиента
            string answerText = "Ваше сообщение доставленно!";
            byte[] answerData = Encoding.UTF8.GetBytes(answerText);

            try
            {
                //связать конечную точку и сокет
                server.Bind(localEndPoint);

                // прослушивание подключений, 10 мест в очереди подключений
                server.Listen(10);
                Console.WriteLine("Server started, accept connections...");
                while (true)
                {
                    // получаем следующее подключение из очереди
                    Socket client = server.Accept();
                    Console.WriteLine("Accept connection: " + client.RemoteEndPoint.ToString());
                    
                    // строковый буфер для получения сообщение
                    StringBuilder builder = new StringBuilder();
                    // кол-во прочитанных байт
                    int len = 0;
                    // байтовый буфер для получения сообщений
                    byte[] data = new byte[256];

                    do
                    {
                        // читаем полученный пакет данных
                        len = client.Receive(data);
                        builder.Append(Encoding.UTF8.GetString(data, 0, len));
                    } while (client.Available > 0);
                    DateTime time = DateTime.Now;
                    Console.WriteLine($"Incoming at ({time.ToLongTimeString()}) >> {builder}");

                    // отправка ответа клиенту
                    client.Send(answerData);

                    // отключить сокет
                    client.Shutdown(SocketShutdown.Both);
                    // закрыть подключение
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERR: " + ex.Message);
            }
        }
    }
}
