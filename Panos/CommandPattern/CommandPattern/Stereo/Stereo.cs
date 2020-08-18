using System;

namespace CommandPattern
{
    public class Stereo
    {
        private string room;

        private float volume;

        public Stereo(string room)
        {
            this.room = room;
        }

        public void On()
        {
           Console.WriteLine("Stereo is on");
        }

        public void Of()
        {
            Console.WriteLine("Stereo is Of");
        }

        public void SetCD()
        {
            Console.WriteLine("CD is set");
        }

        public void SetDVD()
        {
            Console.WriteLine("DVD is set");
        }

        public void SetRadio()
        {
            Console.WriteLine("Radio is set");
        }

        public void SetVolume(float volume)
        {
            this.volume = volume;
            Console.WriteLine($"Volume is {volume}");
        }
    }
}
