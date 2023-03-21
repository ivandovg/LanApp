using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LanApp1_3Client
{
    internal class ProgramClient
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Client";

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 1000;

            IPEndPoint remoteEndPoint = new IPEndPoint(ip, port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // подключение к хосту
                socket.Connect(remoteEndPoint);
                Console.Write("Enter message >> ");
                string message = Console.ReadLine();

                byte[] data = Encoding.UTF8.GetBytes(message);

                // отправка пакета хосту
                socket.Send(data);

                // строковый буфер для получения сообщение
                StringBuilder builder = new StringBuilder();
                // кол-во прочитанных байт
                int len = 0;
                // байтовый буфер для получения сообщений
                data = new byte[256];

                do
                {
                    // читаем полученный пакет данных
                    len = socket.Receive(data);
                    builder.Append(Encoding.UTF8.GetString(data, 0, len));
                } while (socket.Available > 0);
                DateTime time = DateTime.Now;
                Console.WriteLine($"Incoming at ({time.ToLongTimeString()}) >> {builder}");

                // отключить сокет
                socket.Shutdown(SocketShutdown.Both);
                // закрыть подключение
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nPress Enter key...");
            Console.ReadLine();
        }
    }
}
