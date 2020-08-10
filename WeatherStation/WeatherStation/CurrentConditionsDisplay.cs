using System;

namespace WeatherStation
{
    public class CurrentConditionsDisplay : IObservable, IDisplayable
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Register(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions : temp: {_temperature}" +
                $" humidity: {_humidity} ");
        }
    }
}

