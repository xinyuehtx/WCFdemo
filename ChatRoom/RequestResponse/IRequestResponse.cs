using System.ServiceModel;

namespace RequestResponse
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