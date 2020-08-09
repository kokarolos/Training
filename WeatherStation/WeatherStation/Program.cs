using System;
using System.Collections.Generic;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsletter = new Newsletter();
            var dog = new Dog();
            newsletter.Register(dog);
            


        }
    }

    public interface ISubject
    {
        void Register(IObserverable observerable);
        void Remove(IObserverable observerable);
        void Notify(IObserverable observerable);

    }
    public interface IObserverable
    {
        void Update();
    }


    public class Newsletter : ISubject
    {
        private List<IObserverable> _observers = new List<IObserverable>();

        public void Notify(IObserverable observerable)
        {
            _observers.ForEach(x => x.Update());
        }

        public void Register(IObserverable observerable)
        {
            _observers.Add(observerable);
            Console.WriteLine($"{observerable.GetType().Name} successfully added to newsletter list");
        }

        public void Remove(IObserverable observerable)
        {
            _observers.Remove(observerable);
        }
    }

    public class Dog : IObserverable
    {
        public void Update()
        {
            Console.WriteLine("Dog");
        }
    }
    public class Duck : IObserverable
    {
        public void Update()
        {
            
        }
    }
    public class Mouse : IObserverable
    {
        public void Update()
        {
            
        }
    }

}

public class WeatherData
{
    //instance variable declarations

    public void MeasurementsChange()
    {
        float temp = GetTemperature();
        float humidity = GetHumidity();
        float pressure = GetPressure();
    }

    public float GetTemperature()
    {
        throw new NotImplementedException();
    }

    public float GetHumidity()
    {
        throw new NotImplementedException();
    }
    public float GetPressure()
    {
        throw new NotImplementedException();
    }

}