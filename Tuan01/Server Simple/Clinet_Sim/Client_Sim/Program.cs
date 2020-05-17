using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_Sim
{
    class Program
    {
        public static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("192.168.1.10", 5000);
            Console.WriteLine("connect succesfull!!");
            Stream stream = tcpClient.GetStream();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
            stream.Read(data, 0, 1024);
            Console.WriteLine(encoding.GetString(data));
            Console.ReadKey();
        }
    }
}
