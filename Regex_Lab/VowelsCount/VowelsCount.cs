using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex("[AEIOUYaeiouy]");

            int count = regex.Matches(text).Count;

            Console.WriteLine($"Vowels: {count}");


        }
    }
}
