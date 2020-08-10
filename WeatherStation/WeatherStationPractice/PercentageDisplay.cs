using System;


namespace WeatherStationPractice
{
    public class PercentageDisplay : IDisplayable
    {

        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"{temperature/100} {humidity/100} {pressure/100}");
        }
    }
}
