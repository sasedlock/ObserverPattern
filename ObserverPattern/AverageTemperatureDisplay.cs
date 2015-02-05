using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AverageTemperatureDisplay : IObserverObject, IDisplay
    {
        private float _currentTemperature;
        private List<float> _historicalTempuratures; 
        private IObservableObject _weatherData;

        public AverageTemperatureDisplay(IObservableObject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.AddObserver(this);
            _historicalTempuratures = new List<float>();
            _currentTemperature = 0;
        }

        public void Update(float tempurature, float humidity, float pressure)
        {
            _currentTemperature = tempurature;
            _historicalTempuratures.Add(_currentTemperature);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("*** Average Temperature ***");
            Console.WriteLine("The last " + _historicalTempuratures.Count + " temperatures average " + _historicalTempuratures.Average());
        }
    }
}
