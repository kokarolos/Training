using System;

namespace WeatherStation
{
    public class StatisticsDisplay : IObservable,IDisplayable
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Register(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Statistics = temp: {_temperature} %" +
                $" humidity: {_humidity}% pressure: {_pressure} ");
        }

    }
}

