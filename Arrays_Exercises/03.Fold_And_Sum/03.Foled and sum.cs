using System;
using System.Linq;
using System.IO;
namespace Fold_And_Sum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = arr.Length / 4;
            
            var leftArr = new int[k];
            var rightArr = new int[k];
            var middleArr = new int[2 * k];
            var finalArr = new int[middleArr.Length];

            for (int i = 0; i < k; i++)
            {
                leftArr[i] = arr[i];
                rightArr[i] = arr[3 * k + i];
            }
            for (int i = 0; i <2 * k; i++)
            {
                middleArr[i] = arr[k + i];
            }

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            for (int i = 0; i < k; i++)
            {
                finalArr[i] += leftArr[i] + middleArr[i];
                finalArr[i + k] += middleArr[i + k] + rightArr[i];
            }

            Console.WriteLine(string.Join(" ", finalArr));

        }
    }
}