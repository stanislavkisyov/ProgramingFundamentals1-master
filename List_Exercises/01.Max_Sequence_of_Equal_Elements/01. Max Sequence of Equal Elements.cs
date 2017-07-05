using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int pos = 0;
            int maxCount = 1;
            int count = 1;
            int maxNum = 0;

            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNum = nums[pos];
                    }

                }
                else
                {
                    count = 1;
                }
                
                pos++;

                if (maxCount == 1)
                {
                    maxNum = nums[0];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum + " ");
            }
        }
    }
}
