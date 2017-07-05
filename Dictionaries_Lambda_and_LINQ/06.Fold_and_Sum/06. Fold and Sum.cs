using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] row1Left = arr.Take(k).Reverse().ToArray();
            int[] row1Right = arr.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

            var result = new List<int>();
            for (int i = 0; i < row2.Length; i++)
            {
                result.Add(row1[i] + row2[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
