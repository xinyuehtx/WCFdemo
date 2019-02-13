using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace UnreliableChannel
{
    public class UnreliableChannel : IDuplexSessionChannel
    {
        public IDuplexSessionChannel InnerChannel { get; private set; }
        public MessageInspector MessageInspector { get; private set; }

        public UnreliableChannel(IDuplexSessionChannel innerChannel, int dropRate)
        {
            this.InnerChannel = innerChannel;
            this.MessageInspector = new MessageInspector(dropRate);
        }

        public void Send(Message message, TimeSpan timeout)
        {
            var processMessage = this.MessageInspector.ProcessMessage(message);
            if (null != processMessage)
            {
                this.InnerChannel.Send(processMessage, timeout);
            }
        }
        public void Send(Message message)
        {
            var processMessage = this.MessageInspector.ProcessMessage(message);
            if (null != processMessage)
            {
                this.InnerChannel.Send(processMessage);
            }
        }

        #region MyRegion

        public EndpointAddress LocalAddress => InnerChannel.LocalAddress;

        public EndpointAddress RemoteAddress => InnerChannel.RemoteAddress;

        public Uri Via => InnerChannel.Via;

        public CommunicationState State => InnerChannel.State;

        public IDuplexSession Session => InnerChannel.Session;

        #endregion

        #region MyRegion

        public event EventHandler Closed;
        public event EventHandler Closing;
        public event EventHandler Faulted;
        public event EventHandler Opened;
        public event EventHandler Opening;

        public IAsyncResult BeginReceive(TimeSpan timeout, AsyncCallback callback, object state)
        {
            return this.InnerChannel.BeginReceive(timeout, callback, state);
        }


        public Message Receive()
        {
            return InnerChannel.Receive();
        }

        public Message Receive(TimeSpan timeout)
        {
            return InnerChannel.Receive(timeout);
        }

        public IAsyncResult BeginReceive(AsyncCallback callback, object state)
        {
            return InnerChannel.BeginReceive(callback, state);
        }

        public Message EndReceive(IAsyncResult result)
        {
            return InnerChannel.EndReceive(result);
        }

        public bool TryReceive(TimeSpan timeout, out Message message)
        {
            return InnerChannel.TryReceive(timeout, out message);
        }

        public IAsyncResult BeginTryReceive(TimeSpan timeout, AsyncCallback callback, object state)
        {
            return InnerChannel.BeginTryReceive(timeout, callback, state);
        }

        public bool EndTryReceive(IAsyncResult result, out Message message)
        {
            return InnerChannel.EndTryReceive(result, out message);
        }

        public bool WaitForMessage(TimeSpan timeout)
        {
            return InnerChannel.WaitForMessage(timeout);
        }

        public IAsyncResult BeginWaitForMessage(TimeSpan timeout, AsyncCallback callback, object state)
        {
            return InnerChannel.BeginWaitForMessage(timeout, callback, state);
        }

        public bool EndWaitForMessage(IAsyncResult result)
        {
            return InnerChannel.EndWaitForMessage(result);
        }

        public IAsyncResult BeginSend(Message message, AsyncCallback callback, object state)
        {
            return InnerChannel.BeginSend(message, callback, state);
        }

        public IAsyncResult BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state)
        {
            return InnerChannel.BeginSend(message, timeout, callback, state);
        }

        public void EndSend(IAsyncResult result)
        {
            InnerChannel.EndSend(result);
        }

        public T GetProperty<T>() where T : class
        {
            return InnerChannel.GetProperty<T>();
        }

        public void Abort()
        {
            InnerChannel.Abort();
        }

        public void Close()
        {
            InnerChannel.Close();
        }

        public void Close(TimeSpan timeout)
        {
            InnerChannel.Close(timeout);
        }

        public IAsyncResult BeginClose(AsyncCallback callback, object state)
        {
            return InnerChannel.BeginClose(callback, state);
        }

        public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            return InnerChannel.BeginClose(timeout, callback, state);
        }

        public void EndClose(IAsyncResult result)
        {
            InnerChannel.EndClose(result);
        }

        public void Open()
        {
            InnerChannel.Open();
        }

        public void Open(TimeSpan timeout)
        {
            InnerChannel.Open(timeout);
        }

        public IAsyncResult BeginOpen(AsyncCallback callback, object state)
        {
            return InnerChannel.BeginOpen(callback, state);
        }

        public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            return InnerChannel.BeginOpen(timeout, callback, state);
        }

        public void EndOpen(IAsyncResult result)
        {
            InnerChannel.EndOpen(result);
        }

        #endregion
    }
}