using System;

namespace Events_Delegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventarg e)
        {

            Console.WriteLine("Mail Service : Sending an email...." + e.Video.Title);
        }
    }
}
