namespace WeatherStationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = WeatherStation.GetWeatherStation();
            var data2 = WeatherStation.GetWeatherStation();
            var forecastApi = new ForecastApi(new PercentageDisplay());
            var forecastPlatform = new ForecastPlatform(new HeatIndexDisplay());
            var forecastApi2 = new ForecastApi(new NormalDisplay());
            data.Register(forecastApi);
            data.Register(forecastPlatform);
            data.Register(forecastApi2);
            data.SetMeasurements(1.2f, 1.5f, 10f);
            data.SetMeasurements(25f, 12f, 19f);

            //SingletonTest
            data2.SetMeasurements(213f, 21f, 61f);
        }
    }
}
