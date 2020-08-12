using System;
namespace DesignPatterns
{
    class RubberDuck : Duck
    {
        public RubberDuck( IFlyable flyable,IQuackable quackable)
        {
            this.quackable = quackable;
            this.flyable = flyable;
        }
    }

}
