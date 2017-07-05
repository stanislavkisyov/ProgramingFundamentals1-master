using System;

namespace Count_Substring_Occurrences
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(word);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(word, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
