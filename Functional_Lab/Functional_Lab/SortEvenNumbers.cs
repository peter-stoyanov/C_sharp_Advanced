using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Lab
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(n => int.Parse(n))
               .Where(n => n % 2 == 0)
               .ToList();

            //Console.WriteLine(String.Join(", ", numbers));
            Console.WriteLine(String.Join(", ", numbers.OrderBy(n => n).ToList()));

        }
    }
}
