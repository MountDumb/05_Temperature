using System;

namespace _05_Temperature
{
    internal enum Unit {Fahrenheit, Celcius }
    internal class TemperatureFactory
    {
        internal static ITemperature Get(Unit u)
        {
            switch (u)
            {
                case Unit.Celcius:

                    Temps celcius = new Celcius();
                    ITemperature cel = (ITemperature)celcius;
                    return cel;

                case Unit.Fahrenheit:

                    Temps fahrenheit = new Fahrenheit();
                    ITemperature far = (ITemperature)fahrenheit;
                    return far;
                default:
                    throw new Exception();
                    
            }
        }

         
        

        
    }
}