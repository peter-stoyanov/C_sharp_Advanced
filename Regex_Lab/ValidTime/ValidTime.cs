using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidTime
{
    class ValidTime
    {
        static void Main(string[] args)
        {
            //11:33:24 AM

            //Is in the interval 00:00:00 AM to 11:59:59 PM
            //Has no redundant symbols before, after or in between

            var validDict = new Dictionary<string, string>();

            const string pattern = @"
                ^                   # start
                [01]\d:
                [012345]\d:
                [012345]\d 
                [ ]
                (AM|PM)
                $
            ";

            Regex regex = new Regex(pattern,
                RegexOptions.IgnorePatternWhitespace);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {

                bool isValid = regex.IsMatch(input);

                if (!validDict.Keys.Contains(input))
                {
                    validDict.Add(input, isValid ? "valid" : "invalid");
                }
            }

            foreach (var pair in validDict)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
