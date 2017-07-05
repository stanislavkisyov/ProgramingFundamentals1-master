using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var namesIpDuration = new SortedDictionary<string, SortedDictionary<string, int>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split();

                var name = tokens[1];
                var ip = tokens[0];
                var durations = int.Parse(tokens[2]);

                if (!namesIpDuration.ContainsKey(name))
                {
                    namesIpDuration[name] = new SortedDictionary<string, int>();
                }

                if (!namesIpDuration[name].ContainsKey(ip))
                {
                    namesIpDuration[name][ip] = 0;
                }
                namesIpDuration[name][ip] += durations;
            }

            foreach (var item in namesIpDuration)
            {
                var name = item.Key;
                var ipsDuration = item.Value;
                var totalDuration = ipsDuration.Sum(a => a.Value);
                var ips = ipsDuration.Keys;
                Console.WriteLine($"{name}: {totalDuration} [{string.Join(", ", ips)}]");
            }
        }
    }
}
