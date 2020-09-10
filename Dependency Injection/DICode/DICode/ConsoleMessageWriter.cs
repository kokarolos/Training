using System;

namespace DICode
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
