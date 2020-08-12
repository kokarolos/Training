namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new WeatherData();
            var display1 = new CurrentConditionsDisplay(data);
            var display2 = new ForecastDisplay(data);
            var display3 = new StatisticsDisplay(data);
            var display4 = new HeatIndexDisplay(data);
            data.SetMeasurements(21.3f, 23.1f, 52.4f);
            data.SetMeasurements(42.3f, 33.1f, 52.4f);
            data.SetMeasurements(19.3f, 63.1f, 52.4f);
            data.SetMeasurements(80.0f, 0.4f, 0f);
        }
    }
}