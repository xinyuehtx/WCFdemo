using System.ServiceModel;

namespace ServiceMode
{
    [ServiceContract]
    public interface IRequestResponse
    {
        [OperationContract]
        void SayHello(string name);
        [OperationContract]
        string SayHello2(string name);
    }
}