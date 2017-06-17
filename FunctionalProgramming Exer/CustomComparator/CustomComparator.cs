using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6	2 4 6 1 3 5

            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Func<int, int, int> comparator = (x, y) =>
            //{
            //    return x % 2 == y % 2 ? 0 : x % 2 == 1 ? -1 : 1;
            //};

            //int Compare(int x, int y) => x % 2 == y % 2 ? 0 : x % 2 == 1 ? -1 : 1;

            //Array.Sort(inputArr, Compare);

            //Console.WriteLine(String.Join(" ", inputArr));


            var evenNumbers = inputArr.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            var oddNumber = inputArr.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

            evenNumbers.AddRange(oddNumber);
            Console.WriteLine(string.Join(" ", evenNumbers));

        }
    }
}
