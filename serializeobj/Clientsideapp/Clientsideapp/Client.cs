using System;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Clientside
{
    class Client
    {
        static void Main(string[] args)
        {
            Person P = new Person();
            var data = JsonConvert.SerializeObject(P);
            TcpClient client = new TcpClient("172.16.14.124", 8080);
            Console.WriteLine("Connected to server");
            NetworkStream n = client.GetStream();
            Console.WriteLine("connected");
          
            byte[] message = Encoding.Unicode.GetBytes(data);
            n.Write(message, 0, message.Length);
            Console.WriteLine("message sent");
            client.Close();
            Console.ReadKey();


        }
    }
}
