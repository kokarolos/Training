using System;

namespace Facade
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popper is on");
        }

        public void Pop()
        {
            Console.WriteLine("Now ot popping");
        }

        public void Off()
        {
            Console.WriteLine("Popper is off");
        }
    }
}