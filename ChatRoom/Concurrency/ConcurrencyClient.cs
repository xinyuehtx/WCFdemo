using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Concurrency
{
    public class ConcurrencyClient:DuplexClientBase<IConcurrency>,IConcurrency
    {
        public ConcurrencyClient(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress) : base(callbackInstance, binding, remoteAddress)
        {
        }

        public void SayHello(string name)
        {
            Channel.SayHello(name);
        }
    }
}