using System;
using System.Linq;
namespace Pairs_by_Difference
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var diff = int.Parse(Console.ReadLine());
            var count = 0;

            foreach (var num in input)
            {
                foreach (var num2 in input)
                {
                    if (num - num2 == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
