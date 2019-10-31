using System;

namespace SumArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17

            int SUM = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            a = Convert.ToInt32(args[0]);
            b = Convert.ToInt32(args[1]);
            c = Convert.ToInt32(args[2]);
            d = Convert.ToInt32(args[3]);

            SUM = a + b + c + d;

            Console.WriteLine("Hasil Penjumlahan: " + SUM);
        }
    }
}
