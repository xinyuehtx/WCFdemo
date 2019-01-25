using System;
using System.Threading;

namespace ServiceMode
{
    public class OneWay : IOneWay
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"before handle:{DateTime.Now:HH:mm:ss,fffff}");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine($"{name} say: Hello");
            Console.WriteLine($"after handle:{DateTime.Now:HH:mm:ss,fffff}");
        }
    }
}