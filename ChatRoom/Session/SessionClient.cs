using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Session
{
    public class SessionClient : ClientBase<ISession>, ISession
    {
        public SessionClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public string SayHello(string name)
        {
            return Channel.SayHello(name);
        }

        public string Talk(string text)
        {
            return Channel.Talk(text);
        }

        public string SayByebye()
        {
            return Channel.SayByebye();
        }
    }
}