using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublesAverage
{
    class DoublesAverage
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            Console.WriteLine(String.Format("{0:0.00}", numbers.Average()));

        }
    }
}
