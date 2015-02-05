﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserverObject
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private IObservableObject _subject;

        public CurrentConditionsDisplay(IObservableObject subject)
        {
            _subject = subject;
        }

        public void Update(float tempurature, float humidity, float pressure)
        {
            _temperature = tempurature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("It is currently " + _temperature + " degrees outside,");
            Console.WriteLine("With a humidity reading of " + _humidity + ",");
            Console.WriteLine("And a pressure reading of " + _pressure);
        }
    }
}
