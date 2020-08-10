using ObserverPattern.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {





            WeatherData wd = new WeatherData();
            CurrentConditions c = new CurrentConditions(wd);
            ForecastDisplay f = new ForecastDisplay(wd);

            wd.SetMeasurements(90, 67, 79);
            wd.SetMeasurements(90, 87, 79);

        }
    }
}
