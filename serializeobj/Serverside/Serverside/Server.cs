using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpListener listen = new TcpListener(IPAddress.Any, 8080);
            Console.WriteLine("Listening...");
            listen.Start();
            TcpClient client = listen.AcceptTcpClient();
            Console.WriteLine("Connected");
            NetworkStream Stream = client.GetStream();
            byte[] Clientdata = new byte[2048];
            Stream.Read(Clientdata, 0, Clientdata.Length);

            string stringdata = Encoding.ASCII.GetString(Clientdata);
       
            Console.WriteLine();
            byte[] buffer = new byte[client.ReceiveBufferSize];


            int data = Stream.Read(buffer, 0, client.ReceiveBufferSize);
            string ch = Encoding.Unicode.GetString(buffer, 0, data);
            Console.WriteLine("message is:" + ch);
            client.Close();
            Console.ReadKey();
        }
    }
}