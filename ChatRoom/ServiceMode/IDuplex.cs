using System.ServiceModel;

namespace ServiceMode
{
    [ServiceContract(CallbackContract = typeof(IDuplexCallback))]
    public interface IDuplex
    {
        [OperationContract(IsOneWay = true)]
        void SayHello(string name);
    }

    public interface IDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void Replay(string name);
    }
}