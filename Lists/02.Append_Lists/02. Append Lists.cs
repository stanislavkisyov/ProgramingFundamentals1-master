using System;
using System.Linq;
using System.Collections.Generic;
namespace Append_Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();

            input.Reverse();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
