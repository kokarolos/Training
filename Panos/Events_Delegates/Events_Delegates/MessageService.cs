using System;

namespace Events_Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService : Sending a text message");
        }

    }
}
