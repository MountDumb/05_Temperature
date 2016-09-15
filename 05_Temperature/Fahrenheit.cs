using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    internal class Fahrenheit : Temps, ITemperature 
    {

        public override double Convert(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

    }
}
