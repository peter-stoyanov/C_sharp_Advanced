using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            //too_long_username
            //!lleg@l ch@rs

            //Has length between 3 and 16 characters
            //Contains only letters, numbers, hyphens and underscores
            //Has no redundant symbols before, after or in between

            var usernameValid = new Dictionary<string, string>();

            const string pattern = @"
                ^                   # start
                [\w\d-_]{3,16}
                $
            ";

            Regex regex = new Regex(pattern,
                RegexOptions.IgnorePatternWhitespace);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {

                bool isValid = regex.IsMatch(input);

                if (!usernameValid.Keys.Contains(input))
                {
                    usernameValid.Add(input, isValid ? "valid" : "invalid");
                }
            }

            foreach (var pair in usernameValid)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
