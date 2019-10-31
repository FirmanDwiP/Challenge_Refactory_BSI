using System;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            IsPalindrome("ipsum"); // false
            IsPalindrome("malam"); // true
            IsPalindrome("tidur"); // false
            IsPalindrome("kasur rusak"); // true
            IsPalindrome("ibu ratna antar ubi"); // true

        }

        static bool IsPalindrome(string text)
        {
            // bool isMachine = true;
            // bool isDangerous = false;
            // if (isMachine && isDangerous)
            // {
            //     Console.WriteLine("Shoot!");
            // }
            // else
            // {
            //     Console.WriteLine("Don't shoot");
            // }
            // return true;
        }
    }
}
