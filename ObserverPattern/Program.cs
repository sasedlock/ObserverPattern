using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditions = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(72, 30, 25);
            weatherData.SetMeasurements(75, 32, 30);
            weatherData.SetMeasurements(80, 25, 20);

            Console.ReadLine();
        }
    }
}
