using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ReliableSession
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IReliableSessioon
    {
        [OperationContract(IsInitiating = true)]
        string SayHello(string name);

        [OperationContract(IsOneWay = true)]
        void Talk(string text);

        [OperationContract(IsTerminating = true)]
        string SayByebye();
    }

}
