namespace WeatherStationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = WeatherStation.GetWeatherStation();
            var forecastApi = new ForecastApi(new PercentageDisplay());
            data.Register(forecastApi);
            data.SetMeasurements(1.2f, 1.5f, 10f);
            var forecastPlatform = new ForecastPlatform(new HeatIndexDisplay());
        }
    }
}
