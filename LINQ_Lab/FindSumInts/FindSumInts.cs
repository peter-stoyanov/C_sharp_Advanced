using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInts
{
    class FindSumInts
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Where(n => n.All(c => new char[] { '0','1','2','3','4','5','6','7','8','9','-'}.Contains(c)))
               .Select(int.Parse)
               .ToList();

            Console.WriteLine(numbers.Count > 0 ? numbers.Sum().ToString() : "No match");
        }
    }
}
