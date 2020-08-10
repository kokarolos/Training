namespace WeatherStation
{
    public interface ISubject
    {
        void Register(IObservable observerable);
        void Remove(IObservable observerable);
        void Notify();

    }
}

