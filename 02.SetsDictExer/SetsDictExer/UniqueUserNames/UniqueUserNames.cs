using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUserNames
{
    class UniqueUserNames
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                userNames.Add(name);
            }

            Console.WriteLine(String.Join("\n",userNames));
        }
    }
}
