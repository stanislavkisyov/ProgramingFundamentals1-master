using System;

namespace Day_of_Week
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] dayOfWeek ={"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(dayOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
