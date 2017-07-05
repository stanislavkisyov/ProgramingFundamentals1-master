using System;
using System.Linq;
namespace Triple_Sum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] items = input.Split(' ');
            var sum = 0;
            var count = 0;
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                     sum = arr[a] + arr[b];
                        if (arr.Contains(sum))
                    {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                            count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
