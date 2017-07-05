using System;
using System.Linq;
namespace Max_Sequence_of_Equal_Elements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var seq = 1;
            var longSeq = 0;

            var sequenceArr = new int[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i-]) == arr[i + 1])
                {
                    seq++;
                }
                if (seq > longSeq)
                {
                    longSeq++;
                }
            }
            Console.WriteLine(longSeq);
        }
    }
}
