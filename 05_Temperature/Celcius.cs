using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    internal class Celcius : ITemperature
    {
        public double Convert(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
        
    }
}
