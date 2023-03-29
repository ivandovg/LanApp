using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanApp5_1ScreenServer
{
    internal class ProgramSrvScreen
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Screen Server";
            Console.Write("Enter port: ");
            int localPort = int.Parse(Console.ReadLine());
            TcpListener tcp = new TcpListener(new IPEndPoint(IPAddress.Any, localPort));
            tcp.Start(10);
            tcp.BeginAcceptTcpClient(AcceptConnection, tcp);
            Console.WriteLine("\n\nPress ENTER for exit...");
            Console.ReadLine();
        }

        private static void AcceptConnection(IAsyncResult result)
        {
            TcpListener srv = result.AsyncState as TcpListener;
            TcpClient client = srv.EndAcceptTcpClient(result);
            NetworkStream ns = client.GetStream();
            Bitmap bm = GetScreenBitmap();
            bm.Save(ns, System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine("Send screen to " + client.Client.RemoteEndPoint.ToString());
            System.Threading.Thread.Sleep(1000);
            client.Close();
            srv.BeginAcceptTcpClient(AcceptConnection, srv);
        }

        private static Bitmap GetScreenBitmap()
        {
            // save screen
            Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics GF = Graphics.FromImage(BM);
            // hide window
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            GF.CopyFromScreen(0, 0, 0, 0, BM.Size);

            ShowWindow(handle, SW_SHOW);
            return BM;
        }

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}
