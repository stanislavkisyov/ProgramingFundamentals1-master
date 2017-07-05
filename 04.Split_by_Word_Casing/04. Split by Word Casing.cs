using System;
using System.Collections.Generic;

namespace Split_by_Word_Casing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var separator = new char[] { ',', ':', ';', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCasewords = new List<string>();
            var mixedCaseWords = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int lowerCase = 0;
                int upperCase = 0;
                int mixedCase = 0;

                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] >= 97 && input[i][j] <= 122)
                    {
                        lowerCase++;
                    }
                    else if (input[i][j] >= 65 && input[i][j] <= 90)
                    {
                        upperCase++;
                    }
                    else
                    {
                        mixedCase++;
                    }
                }

                if (lowerCase == 0 && upperCase > 0 && mixedCase == 0)
                {
                    upperCasewords.Add(input[i]);
                }
                else if(lowerCase > 0 && upperCase == 0 && mixedCase == 0)
                {
                    lowerCaseWords.Add(input[i]);
                }
                else if(lowerCase >= 0 && upperCase >= 0 && mixedCase >= 0)
                {
                    mixedCaseWords.Add(input[i]);
                }

            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCasewords)}");
        }
    }
}