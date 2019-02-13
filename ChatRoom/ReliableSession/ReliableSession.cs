using System;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableSession
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class ReliableSession : IReliableSessioon
    {
        private string _name;

        public string SayHello(string name)
        {
            _name = name;
            return $"{_name}:Hello";
        }

        public void Talk(string text)
        {
            Thread.Sleep(100);
            var s = $"{_name}:{text}";
            Console.WriteLine(s);
        }

        public string SayByebye()
        {
            return $"{_name}:Byebye";
        }
    }
}