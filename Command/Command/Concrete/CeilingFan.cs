using System;

namespace Command
{
    public class CeilingFan : ISwitchable
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        public string Position { get; set; }
        public int Speed { get; set; }

        public CeilingFan(string position)
        {
            Position = position;
            Speed = OFF;
        }

        public void On()
        {
            Console.WriteLine($"ceilingfan turned on");
        }

        public void Off()
        {
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
        }

        public void Medium()
        {
            Speed = MEDIUM;
        }

        public void Low()
        {
            Speed = LOW;
        }
    }
}
