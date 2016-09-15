using System;

namespace _05_Temperature
{
    internal enum Unit {Fahrenheit, Celcius, MasterDegree }
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

        internal static IMaster GiveMasterDegree(Unit u)
        {
            if (u == Unit.MasterDegree)
            {
                IMaster master = new MasterDegree();
                return master;
            }
            else
            {
                IMaster celciusmasterdegree = new Celcius();
                return celciusmasterdegree;
            }
        }

         
        

        
    }
}