using System;

namespace TestTemperatureConverter
{
    class Program
    {
        private static TemperatureConverter.Class1 tempConvert = new TemperatureConverter.Class1();
        private static double[] Temperatures = { 60.0, 68.4, 72.2, 80.1, 20.8, 12.2 };
        static void Main(string[] args)
        {
            Console.WriteLine(tempConvert.CtoF(20));

            Console.WriteLine("Fah array");
            foreach (double temp  in Temperatures)
            {
                Console.WriteLine(temp);
            }

            convertCArray();

            Console.WriteLine("Celsius array");
            foreach (double temp in Temperatures)
            {
                Console.WriteLine(temp);
            }
        }

        private static void convertCArray()
        {
            for (int i = 0; i < Temperatures.Length; i++)
            {
                Temperatures[i] = tempConvert.CtoF(Temperatures[i]);
            }
        }
    }
}
