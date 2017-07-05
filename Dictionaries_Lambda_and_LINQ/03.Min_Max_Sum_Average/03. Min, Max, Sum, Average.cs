using System;
using System.Collections.Generic;
using System.Linq;
namespace Min_Max_Sum_Average
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {result.Sum()}");
            Console.WriteLine($"Min = {result.Min()}");
            Console.WriteLine($"Max = {result.Max()}");
            Console.WriteLine($"Average = {result.Average()}");
        }
    }
}
