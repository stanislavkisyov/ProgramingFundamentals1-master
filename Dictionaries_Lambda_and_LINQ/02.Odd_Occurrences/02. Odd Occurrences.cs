using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string[] words = input.Split(' ');

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            var result = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
