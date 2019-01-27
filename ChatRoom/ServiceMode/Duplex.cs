using System;
using System.ServiceModel;

namespace ServiceMode
{
    public class Duplex : IDuplex
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"{name} say: Hello");
            Callback.Replay("Service");
        }

        private IDuplexCallback Callback => OperationContext.Current.GetCallbackChannel<IDuplexCallback>();
    }
}