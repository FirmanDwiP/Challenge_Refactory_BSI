using System;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
            Array.Sort(points);

            // reverse array 
            Array.Reverse(points);

            // print all element of array 
            foreach (int value in points)
            {
                Console.Write(value + " ");
            }
        }
    }
}
