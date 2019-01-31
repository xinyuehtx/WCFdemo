using System.ServiceModel;

namespace Fault
{
    [ServiceContract(CallbackContract = typeof(IFaultCallback),SessionMode = SessionMode.Required)]
    public interface IFault
    {
        [OperationContract(IsOneWay = true)]
        void SayHello(string name);
    }

    public interface IFaultCallback
    {
        [OperationContract(IsOneWay = true)]
        void Replay(string name);

        [OperationContract(IsOneWay = true)]
        void OnError(ServiceFault fault);
    }
}