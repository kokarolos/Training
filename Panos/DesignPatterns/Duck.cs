using System;

namespace DesignPatterns
{
    public abstract class Duck
    {
        protected IFlyable flyable;
        protected IQuackable quackable;

        public Duck()
        {

        }

        public void PerformFly()
        {
            flyable.Fly();
        }

        public void PerformQuack()
        {
            quackable.Quackk();
        }


        public void Display()
        {
            Console.WriteLine(this.GetType().Name);
        }

        public void Swim()
        {
            Console.WriteLine("I can Swim");
        }
        public void SetFlyingMethod(IFlyable flyingMethod)
        {
            flyable = flyingMethod;
        }
        public void SetFlyingMethod(IQuackable quiackingMethod)
        {
            quackable = quiackingMethod;
        }


    }

}
