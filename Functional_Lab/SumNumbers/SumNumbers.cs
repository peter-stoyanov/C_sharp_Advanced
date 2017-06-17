using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            //custom parser
            Func<string, int> parser = n => int.Parse(n);

            var numbers = Console.ReadLine()
               .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(parser)
               .ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
