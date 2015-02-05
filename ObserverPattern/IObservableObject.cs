using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObservableObject
    {
        void AddObserver(IObserverObject observer);
        void RemoveObserver(IObserverObject observer);
        void Notify();
    }

    public class WeatherData : IObservableObject
    {
        private float _tempurature;
        private float _humidity;
        private float _pressure;
        private List<IObserverObject> _observers;

        public WeatherData()
        {
            _observers = new List<IObserverObject>();
            _tempurature = 0;
            _humidity = 0;
            _pressure = 0;
        }

        public void AddObserver(IObserverObject observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserverObject observer)
        {
            var observerIndex = _observers.IndexOf(observer);
            _observers.RemoveAt(observerIndex);
        }

        public void Notify()
        {
            foreach (var observerObject in _observers)
            {
                observerObject.Update(_tempurature, _humidity, _pressure);
            }
        }

        public void SetTempurature(float temp)
        {
            _tempurature = temp;
        }

        public void SetHumidity(float hum)
        {
            _humidity = hum;
        }

        public void SetPressure(float press)
        {
            _pressure = press;
        }
    }
}
