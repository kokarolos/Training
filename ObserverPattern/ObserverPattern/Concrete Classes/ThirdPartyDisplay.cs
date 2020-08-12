using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete_Classes
{
    class ThirdPartyDisplay : Observer, DisplayElement
    {
        public void Display()
        {
            //
        }

        public void Update(float temp, float humitidy, float pressure)
        {
            //
        }
    }
}
