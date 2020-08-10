using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete_Classes
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humitidy;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);

        }

        public void Update(float temperature, float humitidy, float pressure)
        {
            this.temperature = temperature;
            this.humitidy = humitidy;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"F: {temperature} F Deegres and humitidy {humitidy}%");
        }
    }
}
