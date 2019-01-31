using System.ServiceModel;

namespace Fault
{
    [ServiceContract(CallbackContract = typeof(IFaultCallback))]
    public interface IFault
    {
        [FaultContract(typeof(ServiceFault))]
        [OperationContract(IsOneWay = true)]
        void SayHello(string name);
    }

    public interface IFaultCallback
    {
        [OperationContract(IsOneWay = false)]
        void Replay(string name);
    }
}