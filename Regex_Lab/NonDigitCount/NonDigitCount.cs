using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NonDigitCount
{
    class NonDigitCount
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            Regex regex = new Regex("[^0123456789]");

            int count = regex.Matches(text).Count;

            Console.WriteLine($"Non-digits: {count}");

        }
    }
}
