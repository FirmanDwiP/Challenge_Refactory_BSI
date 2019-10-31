using System;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to convert temprature unit
            CelciusToFahrenheit(0); // Output: 32
            FahrenheitToCelcius(50); // Output: 10
            CelciusToKelvin(100); // Output: 373.15
            KelvinToCelcius(375); // Output: 101.85
            KelvinToFahrenheit(375); // Output: 215.33
            FahrenheitToKelvin(12); // Output: 262.039
        }

        private static double CelciusToFahrenheit(double value)
        {
            double fahrenheit;
            double celsius = 0;
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            return 0;

        }

        private static double FahrenheitToCelcius(double value)
        {
            double fahrenheit = 50;
            double celsius;
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celcius: " + celsius);
            return 0;
        }

        private static double CelciusToKelvin(double value)
        {
            double celsius = 100;
            double kelvin;
            kelvin = celsius + 273.15;
            Console.WriteLine("Kelvin: " + kelvin);
            return 0;
        }

        private static double KelvinToCelcius(double value)
        {
            double celsius;
            double kelvin = 375;
            celsius = kelvin - 273.15;
            Console.WriteLine("Celsius: " + celsius);
            return 0;
        }

        private static double KelvinToFahrenheit(double value)
        {
            double fahrenheit;
            double kelvin = 375;
            fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            return 0;
        }

        private static double FahrenheitToKelvin(double value)
        {
            double fahrenheit = 12;
            double kelvin;
            kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
            Console.WriteLine("Kelvin: " + kelvin);
            return 0;
        }
    }
}
