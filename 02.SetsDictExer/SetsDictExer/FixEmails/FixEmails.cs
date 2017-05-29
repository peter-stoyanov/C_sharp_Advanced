using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            //Ivan
            //ivanivan@abv.bg


            var emails = new Dictionary<string, string>();

            var name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                if (email.ToLower().EndsWith("us") || email.ToLower().EndsWith("us"))
                {
                    continue;
                }

                if (emails.ContainsKey(name))
                {
                    emails[name] = email;
                }
                else
                {
                    emails.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
