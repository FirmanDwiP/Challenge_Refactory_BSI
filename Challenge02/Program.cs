using System;

namespace DaysToNextBirthday
{
    class Program
    {
        static void Main(string[] args)
        {

            //Count the days of your next birthday
            DateTime bday = DateTime.Parse("29/07/2020");
            DateTime today = DateTime.Parse(DateTime.Now.ToString());
            int ultah = (bday - today).Days;
            Console.WriteLine($"{ultah} hari lagi ulang tahun saya.");
        }
    }
}
