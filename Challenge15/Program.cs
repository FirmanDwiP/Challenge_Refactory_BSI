using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Words = "--vv";
            char[] array = Words.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
            Console.WriteLine(Words);
        }
    }
}
