using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lab
{
    class TakeTwo
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            var two = numbers.Where(n => n >= 10 && n <= 20).Distinct().Take(2);

            Console.WriteLine(two.Count() > 0 ? String.Join(" ", two) : String.Empty);
        }
    }
}
