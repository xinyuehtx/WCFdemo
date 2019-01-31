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
    }
}