using System;
using System.Linq;

namespace Sort_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            nums.Sort();
           Console.WriteLine(string.Join(" <= ", nums)); 
        }
    }
}
