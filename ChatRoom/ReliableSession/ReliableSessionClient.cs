using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ReliableSession
{
    public class ReliableSessionClient : ClientBase<IReliableSessioon>, IReliableSessioon
    {
        public ReliableSessionClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public string SayHello(string name)
        {
            return Channel.SayHello(name);
        }

        public void Talk(string text)
        {
            Channel.Talk(text);
        }

        public string SayByebye()
        {
            return Channel.SayByebye();
        }
    }
}