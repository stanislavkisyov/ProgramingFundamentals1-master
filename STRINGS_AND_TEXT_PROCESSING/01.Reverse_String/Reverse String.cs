using System;
using System.Linq;

namespace Reverse_String
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = string.Join("", input.Reverse());
            Console.WriteLine(reversed);
        }
    }
}
