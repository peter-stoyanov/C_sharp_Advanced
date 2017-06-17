using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').ToArray();

            Predicate<string> hasValidLength = (x) => x.Length <= n;

            Console.WriteLine(String.Join("\n", input.Where(x => hasValidLength.Invoke(x))));
        }
    }
}
