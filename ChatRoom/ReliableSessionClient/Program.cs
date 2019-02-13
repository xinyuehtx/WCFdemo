using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using ReliableSession;
using UnreliableChannel;

namespace ReliableSessionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var reliable = new ReliableSessionBindingElement() { Ordered = true };
            var unreliableElement = new UnreliableElement(20);
            var transportBindingElement = new TcpTransportBindingElement();
            var customBinding = new CustomBinding(reliable,unreliableElement, transportBindingElement);
            var endpointAddress = new EndpointAddress(new Uri("net.tcp://localhost:8888/service"));

            var client = new ReliableSession.ReliableSessionClient(customBinding, endpointAddress);

            Console.WriteLine(client.SayHello("Client"));
            for (int i = 0; i < 20; i++)
            {
                client.Talk($"Are you OK?{i}");
            }

            Console.WriteLine(client.SayByebye());
            Console.Read();
        }
    }
}