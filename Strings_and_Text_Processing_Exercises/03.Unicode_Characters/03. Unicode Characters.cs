using System;
using System.Collections.Generic;
using System.Linq;

namespace Unicode_Characters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            Console.WriteLine(string.Concat(chars));
        }
    }
}
