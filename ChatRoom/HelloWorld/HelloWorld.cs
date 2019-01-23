using System;

namespace HelloWorld
{
    public class HelloWorld : IHelloWorld
    {
        public void SayHello()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}