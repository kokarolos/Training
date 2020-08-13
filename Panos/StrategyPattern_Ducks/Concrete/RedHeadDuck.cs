using System;

namespace DesignPatterns
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck(IFlyable flyable, IQuackable quackable)
        {
            this.flyable = flyable;
            this.quackable = quackable;
        }
    }

}
