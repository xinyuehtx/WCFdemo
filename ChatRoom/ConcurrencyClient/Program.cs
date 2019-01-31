using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Concurrency;

namespace ConcurrencyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动客户端");

            var context = new InstanceContext(new ConcurrencyCallback());
            var client = new Concurrency.ConcurrencyClient(context, new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));
            client.SayHello("Client1");
            client.SayHello("Client2");
            client.SayHello("Client3");
            client.SayHello("Client4");
            client.SayHello("Client5");

            Console.Read();
        }
    }
}