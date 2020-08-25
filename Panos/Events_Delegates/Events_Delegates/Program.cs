using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Events_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber
            var notService = new NotificationService();



            // lets do the subscription

            //publisher  // event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += notService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
