using System;

namespace Command
{
    public class Stereo : ISwitchable
    {
        public string Position { get; set; }
        public Stereo(string position)
        {
            Position = position;
        }
        public void On()
        {
            Console.WriteLine("stereo on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo off");
        }

        public void SetCD()
        {
            Console.WriteLine("Cd setted");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume setted to {volume}");
        }

    }
}
