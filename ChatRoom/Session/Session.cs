using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Session : ISession
    {
        private string _name;

        public string SayHello(string name)
        {
            _name = name;
            return $"{_name}:Hello";
        }

        public string Talk(string text)
        {
            return $"{_name}:{text}";
        }

        public string SayByebye()
        {
            return $"{_name}:Byebye";
        }
    }
}