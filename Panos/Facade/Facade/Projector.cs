using System;

namespace Facade
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("wideScreenMode is on");
        }

        public void Off()
        {
            Console.WriteLine("Projector is Of");
        }
    }
}