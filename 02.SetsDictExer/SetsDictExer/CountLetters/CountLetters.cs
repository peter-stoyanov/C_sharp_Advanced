using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {

            var chars = Console.ReadLine().ToCharArray().ToList();

            var converted = chars.ConvertAll(x => new { value = x, repeated = chars.FindAll(y => y == x).Count });

            foreach (var i in converted.Distinct().OrderBy(x => x.value))
            {
                Console.WriteLine($"{i.value}: {i.repeated} time/s");
            }

        }
    }
}
