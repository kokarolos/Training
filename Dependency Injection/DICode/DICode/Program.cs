using System;

namespace DICode
{
    class Program
    {
        static void Main(string[] args)
        {
            var salutation = new Salutation(new ConsoleMessageWriter());
            salutation.Exclaim();
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
    }
}
