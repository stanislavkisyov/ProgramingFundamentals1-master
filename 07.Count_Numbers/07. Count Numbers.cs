using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var count = new int[nums.Max() + 1];
            foreach (var num in nums)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i]> 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
