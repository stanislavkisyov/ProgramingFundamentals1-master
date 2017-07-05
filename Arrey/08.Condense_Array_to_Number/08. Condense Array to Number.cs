using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var condenseArr = new int[inputArr.Length - 1];

            if (inputArr.Length == 1)
            {
                Console.WriteLine(inputArr[0]);
                return;
            }

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int prev = 0; prev < condenseArr.Length - i; prev++)
                {
                    condenseArr[prev] = inputArr[prev] + inputArr[prev + 1];
                }

                inputArr = condenseArr;
            }
            Console.WriteLine(condenseArr[0]);
        }
    }
}
