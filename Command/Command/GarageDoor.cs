using System;

namespace Command
{
    public class GarageDoor 
    {
        public void Up()
        {
            Console.WriteLine("Opening");
        }
        public void Down()
        {
            Console.WriteLine("Closing");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }
}
