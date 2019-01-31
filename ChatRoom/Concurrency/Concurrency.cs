using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Concurrency : IConcurrency
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Start -{GetHashCode()}-{DateTime.Now:HH:mm:ss,fff}");
            Console.WriteLine(name);
            Callback.Replay($"Service:{GetHashCode()}");
            Console.WriteLine(name);
            Console.WriteLine($"End -{GetHashCode()}-{DateTime.Now:HH:mm:ss,fff}");
        }

        private IConcurrencyCallback Callback => OperationContext.Current.GetCallbackChannel<IConcurrencyCallback>();
    }
}