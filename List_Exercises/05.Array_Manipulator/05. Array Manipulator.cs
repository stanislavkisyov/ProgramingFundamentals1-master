using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine();

            while (line != "print")
            {
                var tokens = line.Split();
                var comands = tokens[0];

                if (comands == "add")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);
                    list.Insert(index, element);
                }

                else if (comands == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    var elements = new List<int>();
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var currentItem = int.Parse(tokens[i]);
                        elements.Add(currentItem);
                    }
                    list.InsertRange(index, elements);
                }

                else if (comands == "contains")
                {
                    var element = int.Parse(tokens[1]);
                    var index = list.IndexOf(element);
                    Console.WriteLine(index);
                }

                else if (comands == "remove")
                {
                    var index = int.Parse(tokens[1]);
                    list.RemoveAt(index);
                }
                else if (comands == "shift")
                {
                    var count = int.Parse(tokens[1]);
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (comands == "sumPairs")
                {
                    var pairSum = new List<int>();
                    for (int i = 0; i < list.Count; i+=2)
                    {
                        var currentElement = list[i];
                        var nextElement = 0;

                        if (i < list.Count - 1)
                        {
                            nextElement = list[i + 1];
                        }
                        var sumElements = currentElement + nextElement;

                        pairSum.Add(sumElements);
                    }
                    list = pairSum;
                }

                line = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}
