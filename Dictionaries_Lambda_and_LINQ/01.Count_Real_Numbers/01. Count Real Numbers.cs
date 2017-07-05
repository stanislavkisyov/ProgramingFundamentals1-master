using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var couts = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                if (couts.ContainsKey(num))
                {
                    couts[num]++;
                }
                else
                {
                    couts[num] = 1;
                }
            }

            foreach (var num in couts.Keys)
            {
                Console.WriteLine($"{num} -> {couts[num]}" );
            }
        }
    }
}
