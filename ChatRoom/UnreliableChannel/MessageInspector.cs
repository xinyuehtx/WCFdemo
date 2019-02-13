using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace UnreliableChannel
{
    public class MessageInspector
    {
        private readonly Random _random;

        public MessageInspector(int dropRate)
        {
            DropRate = dropRate;
            _random = new Random();
        }

        public int DropRate { get; }

        public Message ProcessMessage(Message message)
        {
            var random = _random.Next(100);
            if (random <= DropRate)
            {
                return null;
            }

            return message;
        }
    }
}