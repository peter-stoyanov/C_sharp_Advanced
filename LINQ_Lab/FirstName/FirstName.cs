using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
              .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            var lettersToSearch = new HashSet<char>();

            var letters = Console.ReadLine()
              .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
              .Select(l => lettersToSearch.Add(l[0]))
              .ToList();

            var firstMatch = words.Where(w => lettersToSearch.Contains(w.ToLower()[0])).OrderBy(w => w).FirstOrDefault();

            Console.WriteLine(firstMatch != null ? firstMatch : "No match");
        }
    }
}
