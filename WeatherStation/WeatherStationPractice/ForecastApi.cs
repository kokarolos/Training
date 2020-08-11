namespace WeatherStationPractice
{
    public class ForecastApi : IObservable
    {
        private IDisplayable _displayMethod;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public ForecastApi(IDisplayable displayable)
        {
            _displayMethod = displayable;
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
            _displayMethod.Display(_temperature,_humidity,_pressure);
        }
    }
}
