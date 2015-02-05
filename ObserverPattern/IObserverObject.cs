using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserverObject
    {
        void Update(float tempurature, float humidity, float pressure);
    }
}
