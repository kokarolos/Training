using System;
using System.Runtime.Remoting.Messaging;
using System.Configuration;
using System.Threading;
using Xunit;
using Moq;

namespace DICode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var t = ConfigurationManager.AppSettings["messageWriter"];
            // var typeName = typeof(ConsoleMessageWriter);
            // var type = Type.GetType(typeName.ToString(), true);
            // IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);
            IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter());
            writer.Write("sadas");
            var salutation = new Salutation(writer);
            salutation.Exclaim();
            //salutation.ExclaimWillWriteCorrectMessageToMessageWriter();
        }
    }
    public interface IMessageWriter
    {
        void Write(string content);
    }

    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
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

    public class Salutation
    {
        private IMessageWriter _messageWriter;
        public Salutation(IMessageWriter messageWriter)
        {
            _messageWriter = messageWriter ?? throw new ArgumentException("Writer");
        }

        public void Exclaim()
        {
            _messageWriter.Write("Hello DI!");
        }

        [Fact]
        public void ExclaimWillWriteCorrectMessageToMessageWriter()
        {
            var writerMock = new Mock<IMessageWriter>();
            var sut = new Salutation(writerMock.Object); //Dynamically created instace of IMessageWriter
            sut.Exclaim();
            writerMock.Verify(w => w.Write("Hello DI"));
        }
    }
}
