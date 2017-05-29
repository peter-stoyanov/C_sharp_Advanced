using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var set = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                foreach (var item in input)
                {
                    set.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ", set));
        }
    }
}
