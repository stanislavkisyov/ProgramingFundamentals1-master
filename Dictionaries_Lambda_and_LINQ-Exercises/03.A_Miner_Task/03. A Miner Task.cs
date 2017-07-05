using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var resourcesQuantities = new Dictionary<string, decimal>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var resources = line;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!resourcesQuantities.ContainsKey(resources))
                {
                    resourcesQuantities[resources] = 0;
                }
                resourcesQuantities[resources] += quantity;
                line = Console.ReadLine();

            }

            foreach (var resourceQuantitie in resourcesQuantities)
            {
                var resurses = resourceQuantitie.Key;
                var quatyti = resourceQuantitie.Value;
                Console.WriteLine($"{resurses} -> {quatyti}");
            }
        }
    }
}
