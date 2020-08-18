using System;
namespace CommandPattern
{
    public class Light
    {
        private string room;

        public Light(string room)
        {
            this.room = room;
        }

        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Of()
        {
            Console.WriteLine("Light is of");
        }
    }
}
