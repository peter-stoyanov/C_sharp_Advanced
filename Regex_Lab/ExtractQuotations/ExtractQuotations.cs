using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractQuotations
{
    class ExtractQuotations
    {
        static void Main(string[] args)
        {

            //a href='/' id="home">Home</a><a 

            string input = Console.ReadLine();

            const string pattern = @"
                ('(.*?)'|""(.*?)"")           # end or beginning lazy not greedy here because of ?
            ";

            Regex regex = new Regex(pattern,
                RegexOptions.IgnorePatternWhitespace);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine(groups[2].Value.Length != 0 ? groups[2].Value : groups[3].Value);
            }
        }
    }
}
