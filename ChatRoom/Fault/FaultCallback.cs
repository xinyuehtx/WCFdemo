using System;
using System.ServiceModel;

namespace Fault
{
    public class FaultCallback : IFaultCallback
    {
        public void Replay(string name)
        {
            Console.WriteLine(name);
        }

        public void OnError(ServiceFault fault)
        {
            Console.WriteLine($"error method:{fault.Operation}");
            Console.WriteLine($"error detail:{fault.ServiceException}");
        }
    }
}