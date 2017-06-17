using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseWords
{
    class UppercaseWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
              .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            words = words.Where(checker)
                .ToList();

            Console.WriteLine(String.Join("\n", words));

        }
    }
}
