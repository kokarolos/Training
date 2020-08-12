using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface Observer
    {
        void Update(float temp , float humitidy , float pressure);
    }
}
