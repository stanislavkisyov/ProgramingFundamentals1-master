using System;
using System.Linq;

namespace Short_Words_Sorted
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };

            var words = Console.ReadLine().ToLower().Split(separators).ToList();

            var result = words.Where(x => x != "").OrderBy(x => x).Distinct().Where(x => x.Length < 5);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
