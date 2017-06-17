using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifunction
{
    class Trifunction
    {
        static void Main(string[] args)
        {
            //800
            //Qvor Qnaki Petromir Sadam

            Func<string, int, bool> tester = (name, sum) =>
            {
                if (name.ToCharArray().Select(x => (int)x).Sum() >= sum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            var n = int.Parse(Console.ReadLine());
            var inputArr = Console.ReadLine().Split(' ').ToArray();

            foreach (var name in inputArr)
            {
                if (tester(name, n))
                {
                    Console.WriteLine($"{name}");
                    break;
                }
            }

        }
    }
}
