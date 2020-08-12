using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete_Classes
{
    class CurrentConditions : Observer,DisplayElement
    {
        private float temperature;
        private float humitidy;
        private float pressure;
        private Subject weatherData;

        public CurrentConditions(Subject weatherData)
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
            Console.WriteLine($"Current conditions : {temperature} F Deegres and humitidy {humitidy}% and pressure {pressure}");
         
        }

        
    }
}
