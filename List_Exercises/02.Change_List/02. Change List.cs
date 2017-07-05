using System;
using System.Linq;

namespace Change_List
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            var line = Console.ReadLine();

            while (line != "Odd" || line != "Even")
            {
                var tokens = line.Split();
                var comands = tokens[0];

                if (comands == "Delete")
                {
                    var element = long.Parse(tokens[1]);
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        list.Remove(element);
                    }
                }
                else if (comands == "Insert")
                {
                    var element = long.Parse(tokens[1]);
                    var position = int.Parse(tokens[2]);

                    list.Insert(position, element);
                }

                if (comands == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write(list[i] + " ");

                        }
                    }
                    break;
                }
                else if (comands == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write(list[i] + " ");

                        }
                    }
                    break;
                }
                line = Console.ReadLine();
            }
        }
    }
}
