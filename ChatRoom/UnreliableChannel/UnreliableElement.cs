using System.ServiceModel.Channels;

namespace UnreliableChannel
{
    public class UnreliableElement : BindingElement
    {
        public int DropRate { get; set; }

        public UnreliableElement(int dropRate)
        {
            this.DropRate = dropRate;
        }

        public override BindingElement Clone()
        {
            return new UnreliableElement(DropRate);
        }

        public override T GetProperty<T>(BindingContext context)
        {
            return context.GetInnerProperty<T>();
        }

        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
        {
            return (IChannelFactory<TChannel>) new UnreliableChannelFactory<TChannel>(context, this.DropRate);
        }
    }
}