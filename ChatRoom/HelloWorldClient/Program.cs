using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动客户端");
            var client = new HelloWorldClient(new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/helloworld")));
            client.SayHello();
            Console.Read();
        }
    }
}