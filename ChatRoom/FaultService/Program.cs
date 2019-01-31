﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FaultService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Fault.Fault),
                new Uri("net.tcp://localhost:8888/service")))
            {
                host.Open();
                Console.WriteLine("服务已经开启");
                Console.Read();
            }
        }
    }
}