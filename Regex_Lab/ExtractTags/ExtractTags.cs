using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractTags
{
    class ExtractTags
    {
        static void Main(string[] args)
        {
            //<html lang="en">

            StringBuilder sb = new StringBuilder();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                sb.Append(input);
            }

            const string pattern = @"
                <.*?>           # end or beginning lazy not greedy here because of ?
            ";

            Regex regex = new Regex(pattern,
                RegexOptions.IgnorePatternWhitespace);

            MatchCollection matches = regex.Matches(sb.ToString());

            foreach (Match match in matches)
            {
                //GroupCollection groups = item.Groups;
                Console.WriteLine(match.Value);
            }



        }
    }
}
