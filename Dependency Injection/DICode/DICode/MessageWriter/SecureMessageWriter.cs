using System;
using System.Threading;

namespace DICode
{
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _messageWriter;

        public SecureMessageWriter(IMessageWriter messageWriter)
        {
            if (messageWriter == null)
                throw new ArgumentNullException("writer is null");
            _messageWriter = messageWriter;
        }

        public void Write(string content)
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                _messageWriter.Write(content);
            }
        }
    }
}
