using System.ServiceModel;

namespace Concurrency
{
    [ServiceContract(CallbackContract = typeof(IConcurrencyCallback))]
    public interface IConcurrency
    {
        [OperationContract(IsOneWay = true)]
        void SayHello(string name);
    }

    public interface IConcurrencyCallback
    {
        [OperationContract(IsOneWay = false)]
        void Replay(string name);
    }
}