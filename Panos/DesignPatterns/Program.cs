using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MalardDuck(new FlyNoWay(), new MuteQuack());
            Duck rubberDuck = new RubberDuck(new FlyNoWay(), new MuteQuack());

            Duck redhead = new RedHeadDuck(FlyBehaviorFactory.CreateFlyBehavior(FlyOptions.FlyNoWay),
                                           QuackBehaviorFactory.CreateQuackBehavior(QuackOptions.MuteQuack));
            redhead.PerformFly();
        }

    }


}
