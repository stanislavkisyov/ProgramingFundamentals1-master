using System;
using System.Linq;
namespace Extract_Middle_Elements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int middle = input.Length / 2;

            if (input.Length == 1)
            {
                Console.WriteLine(input[0] );
            }
            else if (input.Length % 2 ==0)
            {
               
                Console.WriteLine($"{input[middle - 1]}, {input[middle]}");                 
            }

            else 
            {
                Console.WriteLine($"{input[middle - 1]}, {input[middle]}, {input[middle + 1]}");
            }
         
        }
    }
}
