using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class QuackBehaviorFactory
    {
        public static IQuackable CreateQuackBehavior(QuackOptions option)
        {

            switch (option)
            {
                case QuackOptions.Quack:
                    return new Quack();

                case QuackOptions.MuteQuack:
                    return new MuteQuack();

                case QuackOptions.Squeack:
                    return new Squeack();
            }

            throw new System.InvalidOperationException();

        }


    }
}
