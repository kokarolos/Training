using System;

namespace CommandPattern
{
    public class GarrageDoor
    {
        private string room;

        public GarrageDoor(string room)
        {
            this.room = room;
        }

        public void Up()
        {
            Console.WriteLine("Garrage Door is Open");
        }
        public void Down()
        {
            Console.WriteLine("Garrage door is closed");
        }
        public void Stop()
        {
            Console.WriteLine("stop door");
        }
    }

}
