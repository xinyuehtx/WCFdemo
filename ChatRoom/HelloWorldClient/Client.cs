using System.ServiceModel;
using System.ServiceModel.Channels;
using HelloWorld;

namespace HelloWorldClient
{
    public class HelloWorldClient : ClientBase<IHelloWorld>, IHelloWorld
    {
        public HelloWorldClient(Binding binding, EndpointAddress address) : base(binding, address)
        {
        }

        public void SayHello()
        {
            Channel.SayHello();
        }
    }
}