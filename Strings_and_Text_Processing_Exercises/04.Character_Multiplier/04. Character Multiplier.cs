using System;

namespace Character_Multiplier
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            var sum = 0;

            var midlleString = Math.Min(firstString.Length, secondString.Length);


            for (int i = 0; i < midlleString; i++)
            {
                var firsLetter = (int)firstString[i];
                var secondLetter = (int)secondString[i];
                sum += firsLetter * secondLetter;
            }
            var longerString = firstString.Length > secondString.Length ? firstString : secondString;

            for (int i = midlleString; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
