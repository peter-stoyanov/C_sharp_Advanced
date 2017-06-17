using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDivisibleBy = (x, div) => x % div == 0;

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(" ", input.Where(x => !isDivisibleBy(x, n)).Reverse()));
        }
    }
}
