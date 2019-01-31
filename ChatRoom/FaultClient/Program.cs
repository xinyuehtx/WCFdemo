using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Fault;

namespace FaultClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动客户端");

            var context = new InstanceContext(new FaultCallback());
            var client = new Fault.FaultClient(context, new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));
            try
            {
                client.SayHello("Client");

            }
            catch (FaultException e)
            {
                Console.WriteLine($"error detail:{e}");
            }

            Console.Read();
        }
    }
}