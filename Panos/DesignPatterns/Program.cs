using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MalardDuck(new FlyWithWings() ,new Squeack());


            mallard.PerformQuack();
            mallard.SetFlyingMethod(new FlyNoWay());
            mallard.PerformFly();
        }
    }


    class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Duck Flying");
        }
    }

    class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Duck CANNOT Fly");
        }
    }

    class Quack : IQuackable
    {
        public void Quackk()
        {
            Console.WriteLine("Duck THAT QUACK ");
        }
    }


    class Squeack : IQuackable
    {
        public void Quackk()
        {
            Console.WriteLine("Duck THAT SQUEAK ");
        }
    }

    class MuteQuack : IQuackable
    {
        public void Quackk()
        {
            Console.WriteLine("NO SOUND ");
        }
    }


}
