using System;
using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<IObservable> _observables;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observables = new List<IObservable>();
        }
        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Notify();
        }
        public void Notify()
        {
            _observables.ForEach(x => x.Update(_temperature,_humidity,_pressure));
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

