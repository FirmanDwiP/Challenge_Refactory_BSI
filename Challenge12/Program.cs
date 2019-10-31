using System;

namespace ToUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a progam that be able to
            // transform all string into uppercase.

            Console.WriteLine("Input someting text(string lho ya!):");
            string input = Console.ReadLine();

            // Covert everything to uppercase  
            string besar = input.ToUpper();
            Console.WriteLine($"Uppercase: {besar}");


        }
    }
}
