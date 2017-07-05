using System;

namespace Text_Filter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] symbol = new char[] { ',', ' ' };
            string[] banWords = Console.ReadLine().Split(symbol, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
