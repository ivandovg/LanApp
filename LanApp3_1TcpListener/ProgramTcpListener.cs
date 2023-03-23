using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace LanApp3_1TcpListener
{
    internal class ProgramTcpListener
    {
        static void Main(string[] args)
        {
            Console.Title = "Test TCPlistener";
            
            TcpServer server = new TcpServer(IPAddress.Any, 5000);
            server.StringMessage += Server_StringMessage;
            server.StartListenAsync();

            Console.WriteLine("press Enter key...");
            Console.ReadLine();
        }

        private static void Server_StringMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
