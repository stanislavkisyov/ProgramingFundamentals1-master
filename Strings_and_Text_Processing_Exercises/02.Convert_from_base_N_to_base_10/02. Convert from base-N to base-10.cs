using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Convert_from_base_N_to_base_10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseN =int.Parse(input[0]);

            var num = input[1].Reverse().ToArray();

            var result = new StringBuilder();

            var sum = new BigInteger();

            for (int power = 0; power < num.Length; power++)
            {
                var currentNumber = int.Parse(num[power].ToString());

                sum += currentNumber * BigInteger.Pow(baseN, power);
            }

            Console.WriteLine(sum);
        }
    }
}
