using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            var list = Console.ReadLine().Split().Select(long.Parse).ToList();

            var manipulationsList = new List<long>();

            var line = Console.ReadLine().Split();

            long firstComands = long.Parse(line[0]);
            int secondComands = int.Parse(line[1]);
            long threeComands = long.Parse(line[2]);

            for (int i = 0; i < firstComands; i++)
            {
                manipulationsList.Add(list[i]);
            }

            manipulationsList.RemoveRange(0, secondComands);

            if (manipulationsList.Contains(threeComands))            
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
