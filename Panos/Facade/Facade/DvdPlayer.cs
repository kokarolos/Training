using System;

namespace Facade
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DvdPlayer is on");
        }

        public void play(string movie)
        {
            Console.WriteLine($"{movie} is playing");
        }

        public void Stop()
        {
            Console.WriteLine("STOP DvdPlayer");
        }

        public void Eject()
        {
            Console.WriteLine("DvdPlayer is ejected");
        }

        public void Off()
        {
            Console.WriteLine("DvdPlayer is off");
        }
    }
}
