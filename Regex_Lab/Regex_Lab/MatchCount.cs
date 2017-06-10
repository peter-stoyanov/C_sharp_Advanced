using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Lab
{
    class MatchCount
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string text = Console.ReadLine();

            Regex regex = new Regex(word);

            int count = regex.Matches(text).Count;

            Console.WriteLine(count);

        }
    }
}
