using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    partial class Program
    {
        static void Main(string[] args)
        {
            WildTurkey turkey = new WildTurkey();
            MallardDuck duck = new MallardDuck();


            Duck turkeyAdapter = new TurkeyAdapter(turkey);
            turkeyAdapter.Fly();
            turkeyAdapter.Quack();

            //Console.WriteLine("The turkey says");
            //turkey.Gobble();
            //turkey.fly();
            //Console.WriteLine("The duck says");
            //testDuck(duck);
            //Console.WriteLine("The TurkeyAdapter says");
            //testDuck(turkeyAdapter);
        }

        static void testDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
