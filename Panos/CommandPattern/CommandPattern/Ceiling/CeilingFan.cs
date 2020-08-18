using System;

namespace CommandPattern
{
    public class CeilingFan 
    {
    
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW =1;
        public static int OFF =1;
        private string room;
        int speed;

        public CeilingFan(string room)
        {
            this.room = room;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
        }

        public void Medium()
        {
            speed = MEDIUM;
        }

        public void Low()
        {
            speed = LOW;
        }

        public void Off()
        {
            speed = OFF;
        }

        public int GetSpeed()
        {
            return speed;
        }
    }

}
