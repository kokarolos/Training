

using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Concrete_Classes
{
    class StatisticsDisplay : Observer, DisplayElement 
    {
        private float temperature;
        private float humitidy;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
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
            Console.WriteLine($"Statistics : {temperature}% F Deegres and humitidy {humitidy}%");
            
        }

      
    }        
    
}