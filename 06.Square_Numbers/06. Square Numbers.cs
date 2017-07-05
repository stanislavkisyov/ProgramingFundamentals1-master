﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Square_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var squares = new List<int>();

            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
