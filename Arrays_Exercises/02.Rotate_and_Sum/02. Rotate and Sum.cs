using System;
using System.Linq;
namespace Rotate_and_Sum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            var sumOfRotate = new int[arr.Length];
            for (int i = 0; i < k; i++)
            {
                RotateArr(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sumOfRotate[j] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ",sumOfRotate));
        }

        private static void RotateArr(int[] arr)
        {
            var lastDigits = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastDigits;
        }
    }
}
