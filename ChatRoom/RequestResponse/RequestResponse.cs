using System;
using System.Threading;

namespace RequestResponse
{
    public class RequestResponse : IRequestResponse
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"{name} say: Hello");
            Thread.Sleep(TimeSpan.FromMinutes(3));
        }

        public string SayHello2(string name)
        {
            Console.WriteLine($"{name} say: Hello");
            Thread.Sleep(TimeSpan.FromMinutes(3));
            return $"Service say: Hello {name}";
        }
    }
}