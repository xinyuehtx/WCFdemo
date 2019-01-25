using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ServiceMode
{
    public class OneWayClient : ClientBase<IOneWay>, IOneWay
    {
        public OneWayClient(Binding binding, EndpointAddress address) : base(binding, address)
        {
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"before send:{DateTime.Now:HH:mm:ss,fffff}");
            Channel.SayHello(name);
            Console.WriteLine($"after send:{DateTime.Now:HH:mm:ss,fffff}");
        }
    }
}