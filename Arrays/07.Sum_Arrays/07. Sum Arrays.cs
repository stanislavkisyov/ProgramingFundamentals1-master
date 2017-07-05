using System;
using System.Linq;
namespace Sum_Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var len = Math.Max(arr1.Length, arr2.Length);

            var result = new int[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            //Console.WriteLine(string.Join(" ", result));
            Console.WriteLine(2 % 7);
        }
    }
}
