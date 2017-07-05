using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = list.OrderByDescending(x =>  x ).Take(3);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
