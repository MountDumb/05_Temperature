namespace _05_Temperature
{
    // Celcius freezes at 0, fahrenheit at 32.
    // Fahrenheit is 5/9 of celsius
    internal enum Unit {Fahrenheit, Celcius }
       

    internal class Temperature
    {
        //Fields
        private double fahrenheit;
        private double celcius;
        
        //Methods
        public Temperature(Unit unit, double temp)
        {
            if (unit == Unit.Fahrenheit)
            {
                fahrenheit = temp;
            }
            else if (unit == Unit.Celcius)
            {
                celcius = temp;
            }
        }
        public Temperature()
        { }     

        public static double FahrenheitToCelcius(double temp)
        {
            return (temp - 32) * 5 / 9; 

        }

        public static double CelciusToFahrenheit(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        // Properties

        public double Fahrenheit
        {
            get { return fahrenheit; }
            set { fahrenheit = value; }
        }

        public double Celcius
        {
            get { return celcius; }
            set { celcius = value; }
        }

    }


}

