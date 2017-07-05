using System;
using System.Collections.Generic;
using System.Linq;
namespace Fix_Emails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var namesEmails = new Dictionary<string, string>();

            while (line != "stop")
            {
                var names = line;
                var email = Console.ReadLine();

                namesEmails[names] = email;

                line = Console.ReadLine();
            }
            var fixedEmails = namesEmails.Where(kvp => !(kvp.Value.EndsWith("uk")|| kvp.Value.EndsWith("us"))).
             ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var nameEmail in fixedEmails)
            {
                var name = nameEmail.Key;
                var email = nameEmail.Value;
                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}
