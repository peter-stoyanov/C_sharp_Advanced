using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOrOdd
{
    class EveOrOdd
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = (x) => x % 2 == 0;
            Predicate<int> isOdd = (x) => x % 2 != 0;

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lowerBound = input[0];
            int upperBound = input[1];

            var command = Console.ReadLine();

            Action<int, Predicate<int>> printer = (n, predicate) =>
            {
                if (predicate.Invoke(n))
                {
                    Console.Write($"{n} ");
                }

            };

            for (int i = lowerBound; i <= upperBound; i++)
            {
                printer(i, command == "even" ? isEven : isOdd);
            }

            Console.WriteLine();


        }
    }
}
