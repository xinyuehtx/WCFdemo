using System.ServiceModel;

namespace Session
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ISession
    {
        [OperationContract(IsInitiating = true)]
        string SayHello(string name);

        [OperationContract]
        string Talk(string text);

        [OperationContract(IsTerminating = true)]
        string SayByebye();
    }
}