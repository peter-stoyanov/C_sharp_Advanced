using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            //7IK9Yo0h
            //9NoBUajQ

            var input = Console.ReadLine();

            var giestSet = new SortedSet<string>();


            while (input != "PARTY")
            {
                giestSet.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                giestSet.Remove(input);

                input = Console.ReadLine();
            }

            if (giestSet.Count == 0)
            {
                Console.WriteLine(giestSet.Count);
            }
            else
            {
                Console.WriteLine(giestSet.Count);

                Console.WriteLine(String.Join("\n", giestSet));
            }
        }
    }
}
