using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class FlyBehaviorFactory
    {

        public static IFlyable CreateFlyBehavior(FlyOptions option)
        {

            switch (option)
            {
                case FlyOptions.FlyNoWay:
                    return new FlyNoWay();

                case FlyOptions.FlyWithWings:
                    return new FlyWithWings();
            }

            throw new System.InvalidOperationException();

        }


    }
}
