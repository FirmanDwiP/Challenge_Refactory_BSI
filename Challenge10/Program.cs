using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create methods called Sum, Substract, Multiply, Divide
            // Each methods should accept two parameters number
            // and also return a number.
            // Example:
            // Sum(1, 6) // Output: 7s

            Console.WriteLine("1.Add (Penambahan)");
            Console.WriteLine("2.Substract (Pengurangan)");
            Console.WriteLine("3.Multiply (Perkalian) ");
            Console.WriteLine("4.Divide (Pembagian)");
            Console.Write("Pilihan(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Bilangan 1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bilangan 2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine($"Sum =({a} + {b}) = {c}");
                    break;
                case 2:
                    Console.Write("Bilangan 1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bilangan 2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine($"Substract = ({a} - {b}) = {c}");
                    break;
                case 3:
                    Console.Write("Bilangan 1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bilangan 2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine($"Multiply = ({a} * {b}) = {c}");
                    break;
                case 4:
                    Console.Write("Bilangan 1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bilangan 2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine($"Divide = ({a} / {b}) = {c}");
                    break;
                default:
                    Console.WriteLine("Pilihan salah, pilihlah 1-4");
                    break;
            }
        }
    }
}