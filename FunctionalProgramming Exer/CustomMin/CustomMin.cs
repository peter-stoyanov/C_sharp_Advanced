using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMin
{
    class CustomMin
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMinimum = (arr) => arr.Min();

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(findMinimum(input));
        }
    }
}
