using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    internal class Celcius : Temps, ITemperature
    {
        public override double Convert(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
        
    }
}
