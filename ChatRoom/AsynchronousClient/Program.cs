using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动客户端");


            var client = new Asynchronous.AsynchronousClient(new NetTcpBinding(),
                new EndpointAddress(new Uri("net.tcp://localhost:8888/service")));

#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            SayHelloTask(client);
            SayHelloTask(client);
            SayHelloTask(client);
            SayHelloTask(client);
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            Console.WriteLine($"发送完成-{DateTime.Now:HH:mm:ss,fff}");
            Console.Read();
        }

        private static async Task SayHelloTask(Asynchronous.AsynchronousClient client)
        {
            try
            {
                Console.WriteLine($"开始发送-{DateTime.Now:HH:mm:ss,fff}");

                var replay = await client.SayHello("Client");
                Console.WriteLine($"收到结果--{DateTime.Now:HH:mm:ss,fff}");

                Console.WriteLine(replay);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}