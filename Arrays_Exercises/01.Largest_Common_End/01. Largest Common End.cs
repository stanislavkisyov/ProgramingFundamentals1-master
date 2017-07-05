using System;
using System.Linq;
namespace Largest_Common_End
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            var len = Math.Min(arr1.Length, arr2.Length);

            var leftCount = 0;
            var rightCount = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftCount++;
                }

                if (arr1[arr1.Length - 1 -i]== arr2[arr2.Length - 1 -i])
                {
                    rightCount++;
                }
            }
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}
