using System;

namespace Last_K_Numbers_Sums
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            decimal[] array = new decimal[n];
            array[0] = 1;

            for (int i = 0; i < n; i++)
            {
                decimal sum = 0;

                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum = sum + array[prev];
                        array[i] = sum;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
