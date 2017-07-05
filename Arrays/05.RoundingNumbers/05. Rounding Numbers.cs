using System;

namespace RoundingNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] items = input.Split(' ');

            var arr = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = double.Parse(items[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
