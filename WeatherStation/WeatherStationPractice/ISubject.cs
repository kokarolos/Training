namespace WeatherStationPractice
{
    public interface ISubject
    {
        void Register(IObservable observable);
        void Remove(IObservable observable);
        void Notify();
    }
}
