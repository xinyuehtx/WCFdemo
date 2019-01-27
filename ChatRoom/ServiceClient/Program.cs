using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Session;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SessionClient(new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));
            Console.WriteLine(client.SayHello("Client"));
            Console.WriteLine(client.Talk("Are you OK?"));
            Console.WriteLine(client.SayByebye());

            client = new SessionClient(new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));
            Console.WriteLine(client.SayHello("Client2"));
            Console.WriteLine(client.Talk("Are you OK?"));
            Console.WriteLine(client.SayByebye());
            Console.Read();
        }
    }
}