using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class AsynchronousClient : ClientBase<IAsynchronous>, IAsynchronous
    {
        public AsynchronousClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public async Task<string> SayHello(string name)
        {
            return await Channel.SayHello(name);
        }
    }
}