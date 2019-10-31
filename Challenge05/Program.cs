using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true
            int angka;
            Console.Write("masukkan Angka : ");
            angka = int.Parse(Console.ReadLine()); // dijadikan menjadi int
            if (angka % 2 == 0)
            {
                Console.Write("Bilangan Genap");
            }
            else
            {
                Console.Write("Bilangan Ganjil");
            }
        }
    }
}
