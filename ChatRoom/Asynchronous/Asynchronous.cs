using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class Asynchronous : IAsynchronous
    {
        public async Task<string> SayHello(string name)
        {
            Console.WriteLine($"收到消息{name}-{DateTime.Now:HH:mm:ss,fff}");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine($"遇到await -{DateTime.Now:HH:mm:ss,fff}");
            await Task.Delay(TimeSpan.FromMinutes(3));
            return $"Hello {name}-{DateTime.Now:HH:mm:ss,fff}";
        }
    }
}