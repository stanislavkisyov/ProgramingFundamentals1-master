using System;

namespace Reverse_Array_of_Integers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arr.Length -1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
