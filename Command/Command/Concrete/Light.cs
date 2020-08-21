using System;

namespace Command
{
    public class Light : ISwitchable
    {
        public string Position { get; set; }

        public Light(string position)
        {
            Position = position;
        }
        public void On()
        {
            Console.WriteLine("Light is on");
        }
        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}
