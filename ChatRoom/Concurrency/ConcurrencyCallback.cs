using System;
using System.ServiceModel;
using System.Threading;

namespace Concurrency
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ConcurrencyCallback : IConcurrencyCallback
    {
        public void Replay(string name)
        {
            Console.WriteLine($"Start -{GetHashCode()}-{DateTime.Now:HH:mm:ss,fff}");
            Console.WriteLine(name);
            Thread.Sleep(TimeSpan.FromSeconds(3));  
            Console.WriteLine($"End -{GetHashCode()}-{DateTime.Now:HH:mm:ss,fff}");
        }
    }
}