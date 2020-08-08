using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MalardDuck : Duck
    {

        public MalardDuck(IFlyable flyable ,IQuackable quackable)
        {
            this.flyable = flyable;
            this.quackable = quackable;
        }
      
    }
}
