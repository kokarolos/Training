using System;

namespace WeatherStationPractice
{
    public class HeatIndexDisplay : IDisplayable
    {
        private readonly double c1 = -42.379d;
        private readonly double c2 = 2.04901523d;
        private readonly double c3 = 10.14333127d;
        private readonly double c4 = -0.22475541d;
        private readonly double c5 = -6.83783 * Math.Pow(10, -3);
        private readonly double c6 = -5.481717 * Math.Pow(10, -2);
        private readonly double c7 = 1.22974 * Math.Pow(10, -3);
        private readonly double c8 = 8.5282 * Math.Pow(10, -4);
        private readonly double c9 = -1.99 * Math.Pow(10, -6);

        public void Display(float temperature, float humidity, float pressure)
        {
            var heatIndex = GetHeatIndex(temperature, humidity, pressure);
            Console.WriteLine($"Heat Index {heatIndex}");
        }

        private double GetHeatIndex(float temperature, float humidity, float pressure)
        {
            var heat = c1 + c2 * temperature + c3 * humidity + c4 * temperature * humidity + c5 * Math.Pow(temperature, 2)
                + c6 * Math.Pow(humidity, 2) + c7 * Math.Pow(temperature, 2) * humidity + c8 * temperature * Math.Pow(humidity, 2) +
                c9 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2);
            return Math.Round(heat);
        }
    }
}
