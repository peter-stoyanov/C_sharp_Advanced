using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperStrings
{
    class UpperStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(w => w.ToUpper())
               .ToList();

            //var two = words.Where(n => n >= 10 && n <= 20).Distinct().Take(2);

            Console.WriteLine(words.Count() > 0 ? String.Join(" ", words) : String.Empty);



        }
    }
}
