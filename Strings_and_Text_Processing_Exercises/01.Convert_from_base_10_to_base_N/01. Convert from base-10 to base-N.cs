using System;
using System.Numerics;
using System.Text;

namespace Convert_from_base_10_to_base_N
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var @base = int.Parse(input[0]);
            BigInteger nums = BigInteger.Parse(input[1]);

            StringBuilder sb = new StringBuilder();

            while (! nums.Equals(0))
            {
                BigInteger reminder = nums % @base;
                nums /= @base;

                sb.Insert(0, reminder);
            }

            Console.WriteLine(sb);
        }
    }
}
