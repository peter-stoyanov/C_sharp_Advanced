using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinEvenNumber
{
    class MinEvenNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            var minEven = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine(minEven.Count > 0 ? minEven.Min().ToString("f2") : "No match");
        }
    }
}
