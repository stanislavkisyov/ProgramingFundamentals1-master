using System;

namespace Reverse_Array_of_Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split(' ');

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];
                var reverse = arr.Length - 1 - i;
                arr[i] = arr[reverse];
                arr[reverse] = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
