using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ServiceMode
{
    public class DuplexClient : DuplexClientBase<IDuplex>, IDuplex
    {
        public DuplexClient(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress) :
            base(callbackInstance, binding, remoteAddress)
        {
        }

        public void SayHello(string name)
        {
            Channel.SayHello(name);
        }
    }

    public class DuplexCallback : IDuplexCallback
    {
        public void Replay(string name)
        {
            Console.WriteLine($"{name} say: Hello");
        }
    }
}