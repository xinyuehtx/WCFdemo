using System.ServiceModel;
using System.Threading.Tasks;

namespace Asynchronous
{
    [ServiceContract]
    public interface IAsynchronous
    {
        [OperationContract]
        Task<string> SayHello(string name);
    }
}