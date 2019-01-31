using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Fault
{
    public class FaultClient : DuplexClientBase<IFault>, IFault
    {
        public void SayHello(string name)
        {
            Channel.SayHello(name);
        }

        public FaultClient(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress) : base(
            callbackInstance, binding, remoteAddress)
        {
        }
    }
}