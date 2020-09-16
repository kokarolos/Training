using System;

namespace DICode
{
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
       //public void ExclaimWillWriteCorrectMessageToMessageWriter()
       //{
       //    var writerMock = new Mock<IMessageWriter>();
       //    var sut = new Salutation(writerMock.Object); //Dynamically created instace of IMessageWriter
       //    sut.Exclaim();
       //    writerMock.Verify(w => w.Write("Hello DI"));
       //}
    }
}
