using System;

namespace WeatherStation
{
    public class HeatIndexDisplay : IObservable, IDisplayable
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        private readonly double c1 = -42.379d;
        private readonly double c2 = 2.04901523d;
        private readonly double c3 = 10.14333127d;
        private readonly double c4 = -0.22475541d;
        private readonly double c5 = -6.83783 * Math.Pow(10, -3);
        private readonly double c6 = -5.481717 * Math.Pow(10, -2);
        private readonly double c7 = 1.22974 * Math.Pow(10, -3);
        private readonly double c8 = 8.5282 * Math.Pow(10, -4);
        private readonly double c9 = -1.99 * Math.Pow(10, -6);


        public HeatIndexDisplay(ISubject weatherData)
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
            Console.WriteLine($"Today's HeatIndex is {GetHeatIndex()}");
        }
        
        private double GetHeatIndex()
        {
            var heat = c1 + c2 * _temperature + c3 * _humidity + c4 * _temperature * _humidity + c5 * Math.Pow(_temperature, 2)
                + c6 * Math.Pow(_humidity, 2) + c7 * Math.Pow(_temperature, 2) * _humidity + c8 * _temperature * Math.Pow(_humidity, 2) +
                c9 * Math.Pow(_temperature, 2) * Math.Pow(_humidity, 2);
            return Math.Round(heat);
        }
    }
}