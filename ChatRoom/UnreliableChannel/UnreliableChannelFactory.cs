using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;

namespace UnreliableChannel
{
    public class UnreliableChannelFactory<TChannel> : ChannelFactoryBase<IDuplexSessionChannel>
    {
        public int DropRate { get; }
        public IChannelFactory<TChannel> InnerChannelFactory { get; }

        public UnreliableChannelFactory(BindingContext context, int dropRate) : base(context.Binding)
        {
            this.InnerChannelFactory = context.BuildInnerChannelFactory<TChannel>();
            this.DropRate = dropRate;
        }
        protected override IDuplexSessionChannel OnCreateChannel(EndpointAddress address, Uri via)
        {
            var channel = InnerChannelFactory.CreateChannel(address, via);
            return new UnreliableChannel((IDuplexSessionChannel) channel, DropRate);
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            return InnerChannelFactory.BeginOpen(timeout, callback, state);
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            InnerChannelFactory.EndOpen(result);
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            InnerChannelFactory.Open(timeout);
        }
    }
}