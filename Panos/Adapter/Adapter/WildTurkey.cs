using System;

namespace Adapter
{
    public class WildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("Im flying s short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
