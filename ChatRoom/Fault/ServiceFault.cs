using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fault
{
    [DataContract]
    public class ServiceFault
    {
        public ServiceFault(Exception e, [CallerMemberName] string operation = null)
        {
            ServiceException = e.ToString();
            Operation = operation;
        }

        [DataMember] public string ServiceException { get; set; }
        [DataMember] public string Operation { get; set; }
    }
}