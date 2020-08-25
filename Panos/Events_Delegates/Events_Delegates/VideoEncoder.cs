using System;

namespace Events_Delegates
{
    public class VideoEventarg : EventArgs
    {
        public Video Video { get; set; }
    }

    // THIS IS THE PUBLISHER OF EVENT
    public class VideoEncoder
    {
        public event EventHandler<VideoEventarg> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            System.Threading.Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        //3 - RAISE THE EVENT
        // make a method responsible for raising the event
        protected virtual void OnVideoEncoded(Video video)
        {
            //we notify subscribers

            if (VideoEncoded != null)
                VideoEncoded(this,new VideoEventarg() {Video=video });
        }
    }
}
