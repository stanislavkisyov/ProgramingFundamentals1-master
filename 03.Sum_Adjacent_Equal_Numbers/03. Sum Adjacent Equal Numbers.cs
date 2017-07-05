using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var count = 0;

            while (count < input.Count - 1)
            {
                if (input[count] == input[count + 1])
                {
                    input[count] += input[count + 1];
                    input.RemoveAt(count + 1);
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}