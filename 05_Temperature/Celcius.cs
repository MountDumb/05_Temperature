using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    //return pi; 
    //return 22 / 7;
    internal class Celcius : ITemperature, IMaster
    {
        public double Convert(double temp)
        {
            return (temp - 32) * 5 / 9;
        
        }

        public string GiveMasterDegree()
        {
            return "You are now a master";
            
        }

    }
}
