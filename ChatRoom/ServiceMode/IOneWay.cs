using System.ServiceModel;

namespace ServiceMode
{
    [ServiceContract]
    public interface IOneWay
    {
        [OperationContract(IsOneWay = true)]
        void SayHello(string name);
    }
}