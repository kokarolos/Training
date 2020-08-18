using System;

namespace Command
{
    public class CeilingFan : ISwitchable
    {
        public string Position { get; set; }

        public CeilingFan(string position)
        {
            Position = position;
        }

        public void On()
        {
            Console.WriteLine($"ceilingfan turned on");
        }

        public void Off()
        {
            Console.WriteLine($"ceilingfan turned off");
        }
    }
}
