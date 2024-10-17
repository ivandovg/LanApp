using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace LanApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowIpInfo("www.microsoft.com");
            ShowIpInfo("www.google.com");
            Console.WriteLine("\nEnter domain name: ");
            ShowIpInfo(Console.ReadLine());
            Console.WriteLine("\nPress Enter key...");
            Console.ReadLine();
        }

        private static void ShowIpInfo(string name)
        {
            IPHostEntry host = Dns.GetHostEntry(name);
            foreach (IPAddress ip in host.AddressList)
            {
                Console.WriteLine($"IP>> {ip}");
            }
        }
    }
}
