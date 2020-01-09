using System;

namespace TemperatureConverter
{
    public class Class1
    {
        public double FtoC(double tempF)
        {
            return (tempF - 32.0) * (5.0 / 9.0);
        }
        public double CtoF(double tempC)
        {
            double temp = ((tempC * (9.0 / 5.0)) + 32.0);
            return temp;
        }
    }
}
