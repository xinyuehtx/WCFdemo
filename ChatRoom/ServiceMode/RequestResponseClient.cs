using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ServiceMode
{
    public class RequestResponseClient : ClientBase<IRequestResponse>, IRequestResponse
    {
        public RequestResponseClient(Binding binding, EndpointAddress address) : base(binding, address)
        {
        }

        public void SayHello(string name)
        {
            Channel.SayHello(name);
        }

        public string SayHello2(string name)
        {
            return Channel.SayHello2(name);
        }
    }
}