using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractNumbers
{
    class ExtractNumbers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //Regex regex = new Regex(@"\D(\d+)\D");
            Regex regex = new Regex(@"[^0123456789]*([0123456789]+)[^0123456789]*");

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                GroupCollection groups = item.Groups;
                Console.WriteLine(groups[1].Value);
            }

        }
    }
}
