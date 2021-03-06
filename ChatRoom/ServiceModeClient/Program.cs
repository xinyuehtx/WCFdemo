﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServiceMode;

namespace ServiceModeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动客户端");
            //var client = new RequestResponseClient(new NetTcpBinding(),
            //    new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));

            //var client = new OneWayClient(new NetTcpBinding(),
            //    new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));

            var context = new InstanceContext(new DuplexCallback());
            var client = new DuplexClient(context, new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));
            client.SayHello("Client");
            //var replay = client.SayHello2("Client");
            //Console.WriteLine(replay);
            Console.Read();
        }
    }
}