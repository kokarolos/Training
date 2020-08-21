using System;

namespace Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Short Distance Flying");
        }

        public void Gobble()
        {
            Console.WriteLine("Goble Goble");
        }
    }
}
