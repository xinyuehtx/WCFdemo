using System;
using System.ServiceModel;

namespace Fault
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Fault : IFault
    {
        public void SayHello(string name)
        {
            try
            {
                Console.WriteLine(name);
                throw new InvalidOperationException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Callback.OnError(new ServiceFault(e));
            }
        }

        private IFaultCallback Callback => OperationContext.Current.GetCallbackChannel<IFaultCallback>();
    }
}