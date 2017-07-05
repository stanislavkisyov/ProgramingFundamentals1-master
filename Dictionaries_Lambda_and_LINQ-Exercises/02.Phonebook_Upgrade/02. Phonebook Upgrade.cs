﻿using System;
using System.Collections.Generic;

namespace Phonebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        var key = input[1];
                        var values = phonebook[input[1]];
                        Console.WriteLine($"{key} -> {values}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }

                else if (input[0] == "ListAll")
                {
                    foreach (var element in phonebook)
                    {
                        var name = element.Key;
                        var number = element.Value;
                        Console.WriteLine($"{name} -> {number}");
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
