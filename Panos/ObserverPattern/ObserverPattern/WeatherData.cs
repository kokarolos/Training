using ObserverPattern.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humitidy;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();

        }
        public void RegisterObserver(Observer o)
        {
            observers.Add(o);

        }

        public void RemoveObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = observers[i];
                observer.Update(temperature, humitidy, pressure);


            }
        }

        public void MeasurementsChanged() 
        {
            NotifyObservers();

        }
        public void SetMeasurements(float temperature, float humitidy, float pressure) 
        {
            this.temperature = temperature;
            this.humitidy = humitidy;
            this.pressure = pressure;
            MeasurementsChanged();


        }



        public void GetTemperature()
        {
            //
        }

        public void GetHumidity() 
        {
            //
        }
        public void GetPressure() 
        {
            //
        }


    }
}

