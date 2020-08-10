using System;
using System.Collections.Generic;


namespace WeatherStationPractice
{
    public class WeatherStation :ISubject
    {
        //Singleton Pattern
        //instance of WeatherStation
        private static WeatherStation _instance;

        private List<IObservable> _observables;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        private static object _syncLock = new object();

        public static WeatherStation GetWeatherStation()
        {
            if (_instance == null){
                lock (_syncLock)
                {
                    if(_instance == null)
                    {
                        _instance = new WeatherStation();
                    }
                }
            }
            return _instance;
        }

        protected WeatherStation()
        {
            _observables = new List<IObservable>();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Notify();
        }

        public void Notify()
        {
            _observables.ForEach(x => x.Update(_temperature, _humidity, _pressure));
        }

        public void Register(IObservable observerable)
        {
            _observables.Add(observerable);
            Console.WriteLine($"{observerable.GetType().Name} successfully added to newsletter list");
        }

        public void Remove(IObservable observerable)
        {
            _observables.Remove(observerable);
        }
    }
}
