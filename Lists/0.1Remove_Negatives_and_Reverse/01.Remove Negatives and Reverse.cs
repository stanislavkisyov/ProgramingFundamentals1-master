using System;
using System.Linq;
using System.Collections.Generic;
namespace Remove_Negatives_and_Reverse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var reversedLists = new List<int>();
            lists.Reverse();
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i] >= 0)
                {
                    reversedLists.Add(lists[i]);
                }
            }
            if (reversedLists.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                
                Console.WriteLine(string.Join(" ", reversedLists));
            }
        }
    }
}
