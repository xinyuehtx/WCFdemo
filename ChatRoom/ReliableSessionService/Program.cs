using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using ReliableSession;
using UnreliableChannel;

namespace ReliableSessionService
{
    class Program
    {
        static void Main(string[] args)
        {
            var reliable = new ReliableSessionBindingElement() {Ordered = true};
            var unreliableElement = new UnreliableElement(20);
            var transportBindingElement = new TcpTransportBindingElement();
            using (var host = new ServiceHost(typeof(ReliableSession.ReliableSession),
                new Uri("net.tcp://localhost:8888/service")))
            {
                host.AddServiceEndpoint(typeof(IReliableSessioon),
                    new CustomBinding(reliable, unreliableElement, transportBindingElement),
                    new Uri("net.tcp://localhost:8888/service"));
                host.Open();
                Console.WriteLine("服务已经开启");
                Console.Read();
            }
        }
    }
}