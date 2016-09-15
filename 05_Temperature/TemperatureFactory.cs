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
                    
                    ITemperature cel = new Celcius();
                    return cel;

                case Unit.Fahrenheit:
                    ITemperature far = new Fahrenheit();
                    return far;
                default:
                    throw new Exception();
                    
            }
        }

         
        

        
    }
}