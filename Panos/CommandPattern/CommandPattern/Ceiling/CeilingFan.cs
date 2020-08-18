using System;

namespace CommandPattern
{
    public class CeilingFan 
    {
    
        private string room;

        public CeilingFan(string room)
        {
            this.room = room;
        }

        public void On()
        {
            Console.WriteLine("Ceilingfan is On");
        }

        public void Of()
        {
            Console.WriteLine("Ceilingfan is Of");
        }
    }

}
