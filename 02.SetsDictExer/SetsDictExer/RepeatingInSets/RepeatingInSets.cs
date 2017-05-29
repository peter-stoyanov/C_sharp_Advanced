using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingInSets
{
    class RepeatingInSets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var n = input[0];
            var m = input[1];

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();

            for (int i = 0; i < n + m; i++)
            {
                if (i < n)
                {
                    var number = int.Parse(Console.ReadLine());
                    setN.Add(number);
                }
                else
                {
                    var number = int.Parse(Console.ReadLine());
                    setM.Add(number);
                }
            }

            setN.IntersectWith(setM);

            Console.WriteLine(String.Join(" ", setN.Distinct()));

        }
    }
}
