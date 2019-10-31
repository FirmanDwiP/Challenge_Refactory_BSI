using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method called "CountString".
            // That method should accept a string and will
            // return length of characters input.
            int dunia = "Hello World!".Length;
            int semesta = "Hello Universe".Length;
            Console.WriteLine($"'Hello World!'{dunia} characters");
            Console.WriteLine($"'Hello Universe!'{semesta} characters");


        }
    }
}
