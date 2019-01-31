using System;
using System.ServiceModel;

namespace Fault
{
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
                throw new FaultException<ServiceFault>(new ServiceFault(e),"服务端错误");
            }

        }
    }
}