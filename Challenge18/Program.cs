using System;

namespace FindMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
                Array.Sort(numbers);
                Console.WriteLine(FindMax(numbers));
                Console.WriteLine(FindMin(numbers));

            }

            static int FindMax(int[] numbers)
            {
                return numbers[numbers.Length - 1];
            }

            static int FindMin(int[] numbers)
            {
                return numbers[0];
            }

            // static int FindAverage(int[] numbers)
            // {
            //     return 0;
            // }
        }
    }
}
