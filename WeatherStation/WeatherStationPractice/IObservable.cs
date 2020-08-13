namespace WeatherStationPractice
{
    public interface IObservable
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
