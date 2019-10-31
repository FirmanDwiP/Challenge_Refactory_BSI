using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
            IsLeapYear(2019);

        }
        private static int IsLeapYear(int value)
        {

            int tahun;
            Console.Write("masukkan tahun: ");
            tahun = int.Parse(Console.ReadLine()); // dijadikan menjadi int
            if (tahun == 2019)
            {
                Console.Write("TRUE");
            }
            else
            {
                Console.Write("FALSE");
            }

            return 0;

        }
    }
}
