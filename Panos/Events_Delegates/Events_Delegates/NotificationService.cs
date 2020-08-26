using System;
namespace Events_Delegates
{
    public class NotificationService
    {
        public  void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Notification Sending");
        }
    }
}
