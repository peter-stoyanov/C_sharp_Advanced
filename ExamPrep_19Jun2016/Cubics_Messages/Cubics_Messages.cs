using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cubics_Messages
{
    class Cubics_Messages
    {
        private static bool IsDigit(char token)
        {
            return Char.IsDigit(token);
        }

        static void Main(string[] args)
        {
            var messagesList = new List<string>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Over!")
            {
                var m = int.Parse(Console.ReadLine());

                string pattern = $@"^([0-9]+)([a-zA-Z]{{{m}}})([^a-zA-Z]*)$";

                Regex rgx = new Regex(pattern);

                if (rgx.Match(line).Success)
                {
                    Match match = rgx.Match(line);

                    GroupCollection groups = match.Groups;

                    string prefix = groups[1].Value;
                    string message = groups[2].Value;
                    string sufix = groups[3].Value;

                    StringBuilder validator = new StringBuilder();


                    foreach (var letter in (prefix + sufix).ToCharArray())
                    {
                        if (!IsDigit(letter)) { continue; }

                        int index = int.Parse(letter.ToString());
                        if (index >= 0 && index < message.Length)
                        {
                            validator.Append(message[index]);
                        }
                        else
                        {
                            validator.Append(" ");
                        }
                    }

                    string verification = validator.Length > 0 ? validator.ToString() : "";

                    messagesList.Add($"{message} == {verification}");

                }
            }

            foreach (var str in messagesList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
