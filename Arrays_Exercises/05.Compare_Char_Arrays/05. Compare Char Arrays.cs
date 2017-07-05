using System.Linq;
using System;
namespace Compare_Char_Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();


            var minLength = Math.Min(arr1.Length, arr2.Length);

                var index1 = arr1[0];
                var index2 = arr2[0];

                if (index1 <= index2 && arr1.Length <= arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }

                else
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
           
            if (arr1 == arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] <= arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        break;
                    }
                }

            }
        }
    }
}
