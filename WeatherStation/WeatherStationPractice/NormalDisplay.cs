using System;


namespace WeatherStationPractice
{
    public class NormalDisplay : IDisplayable
    {
        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"Temp : {temperature} humidity : {humidity} pressure : {pressure}");
        }
    }
}
