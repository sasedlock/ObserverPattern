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
            WeatherData weather = new WeatherData();

            weather.AddObserver(new CurrentConditionsDisplay(weather));

            weather.SetTempurature(72);
            weather.SetHumidity(30);
            weather.SetPressure(25);

            weather.Notify();

            weather.SetTempurature(75);
            weather.SetHumidity(32);
            weather.SetPressure(30);

            weather.Notify();

            Console.ReadLine();
        }
    }
}
