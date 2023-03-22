using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanApp2_2AsyncTcpServer
{
    internal class ClientConnection
    {
        private Socket client;

        public ClientConnection(Socket socket)
        {
            client = socket;
        }

        public Task StartMessagingAsync() => Task.Run(StartMessaging);
        public void StartMessaging()
        {
            string ip=client.RemoteEndPoint.ToString();
            // ответ для клиента
            string answerText = "Ваше сообщение доставленно!";
            byte[] answerData = Encoding.UTF8.GetBytes(answerText);

            // строковый буфер для получения сообщение
            StringBuilder builder = new StringBuilder();
            // кол-во прочитанных байт
            int len = 0;
            // байтовый буфер для получения сообщений
            byte[] data = new byte[256];

            try
            {
                while (true)
                {
                    do
                    {
                        // читаем полученный пакет данных
                        len = client.Receive(data);
                        builder.Append(Encoding.UTF8.GetString(data, 0, len));
                    } while (client.Available > 0);
                    DateTime time = DateTime.Now;
                    Console.WriteLine($"Incoming at ({time.ToLongTimeString()}) >> {builder}");

                    if ("exit".Equals(builder.ToString()))
                    {
                        // отправка ответа клиенту
                        answerData = Encoding.UTF8.GetBytes("Goodbye!");
                        client.Send(answerData);
                        Thread.Sleep(100);
                        break;
                    }

                    // отправка ответа клиенту
                    client.Send(answerData);
                    builder.Clear();
                }

                // отключить сокет
                client.Shutdown(SocketShutdown.Both);
                // закрыть подключение
                client.Close();
                //вывести на консоль сообщение
                Console.WriteLine($"Client '{ip}' disconnect!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
