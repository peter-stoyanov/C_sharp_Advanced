using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam25062017
{
    class _01Regeh
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //[(ASCII Symbols)<(Some digits)REGEH(Some digits)>(ASCII Symbols)] 

            var bracketsPattern = @".*\[.+?\].*";
            //var pattern = @".*\[[ -~]+<([0-9]+)REGEH([0-9]+)>[ -~]+\].*"; //greedy, 0 as single number
            var pattern = @"[ -~]+<([0-9]+)REGEH([0-9]+)>[ -~]+"; //with outer brackets matched already

            var regxBrackets = new Regex(bracketsPattern);
            var regx = new Regex(pattern);

            var sb = new StringBuilder();

            var outerMatches = regx.Matches(input);
            foreach (Match outerMatch in outerMatches)
            {
                string outerMatchCorrected = string.Empty;
                if (outerMatch.Value.LastIndexOf("[") != 0)
                {
                    outerMatchCorrected = outerMatch.Value.Substring(outerMatch.Value.LastIndexOf("["));
                }
                else
                {
                    outerMatchCorrected = outerMatch.Value;
                }

                var matches = regx.Matches(outerMatchCorrected);
                int indexAggregator = 0;
                foreach (Match match in matches)
                {
                    if (match.Value.Contains(" ")) { continue; }

                    for (int group = 1; group <= 2; group++) //check if onyl these groups
                    {
                        int newIndex = int.Parse(match.Groups[group].Value);
                        int indexToPickChar = indexAggregator + newIndex;
                        indexAggregator += newIndex;

                        while (indexToPickChar > input.Length - 1)
                        {
                            //abcd 10   abcdabcdabcd 
                            //0123 
                            // 10 - 4 = 6
                            // 6 - 4 = 2 'c'
                            //indexToPickChar = (indexAggregator + newIndex) % input.Length - 1;
                            indexToPickChar = indexToPickChar - input.Length;
                        }

                        sb.Append(input[indexToPickChar]);
                    }
                }
            }


            Console.WriteLine(sb.ToString());



        }
    }
}
