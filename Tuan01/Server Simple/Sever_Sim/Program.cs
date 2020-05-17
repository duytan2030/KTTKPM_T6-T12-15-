using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sever_Sim
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("192.168.1.10");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            Console.WriteLine("Sever start on " + listener.LocalEndpoint);
            Console.WriteLine("Waiting connect...");
            while (true)
            {
                Socket socket = listener.AcceptSocket();
                Console.WriteLine(socket.LocalEndPoint + " connected!!");
                byte[] data = new byte[1024];
                socket.Receive(data);
                ASCIIEncoding encoding = new ASCIIEncoding();
                string str = encoding.GetString(data);
                socket.Send(encoding.GetBytes("hello from sever " + str));
            }
        }
    }
}
