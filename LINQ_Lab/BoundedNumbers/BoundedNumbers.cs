using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundedNumbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            var numbers = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            var inRange = numbers.Where(n => n >= bounds.Min() && n <= bounds.Max()).ToList();

            if (inRange.Count > 0) { Console.WriteLine(String.Join(" ", inRange)); }


        }
    }
}
