using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByRemainder
{
    class GroupByRemainder
    {
        static void Main(string[] args)
        {
            //1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2

            //var input = Console.ReadLine().Split(',').Select(x => x.Trim()).Select(x => int.Parse(x)).ToList();

            //var sizes = new int[3];
            ////resultArr[0] = new int[input.Count];
            ////resultArr[1] = new int[input.Count];
            ////resultArr[2] = new int[input.Count];

            //foreach (var number in input)
            //{
            //    var remainder = Math.Abs(number % 3);
            //    sizes[remainder]++;
            //}

            //var resultArr = new int[3][] 
            //{
            //    new int[sizes[0]],
            //    new int[sizes[1]],
            //    new int[sizes[2]]
            //};

            //int insertIndex0 = 0;
            //int insertIndex1 = 0;
            //int insertIndex2 = 0;

            //foreach (var number in input)
            //{
            //    switch (Math.Abs(number % 3))
            //    {
            //        case 0:
            //            resultArr[0][insertIndex0] = number;
            //            insertIndex0++;
            //            break;
            //        case 1:
            //            resultArr[1][insertIndex1] = number;
            //            insertIndex1++;
            //            break;
            //        case 2:
            //            resultArr[2][insertIndex2] = number;
            //            insertIndex2++;
            //            break;
            //    }
            //}

            //for (int i = 0; i < resultArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resultArr[i].GetLength(0); j++)
            //    {
            //        if (resultArr[i][j] != 0)
            //        {
            //            Console.Write(resultArr[i][j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            var numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            var jaggedArray = new int[3][];
            var arraysCurrentIndex = new int[3];

            for (int i = 0; i < numbers.Count; ++i)
            {
                var number = numbers.ElementAt(i);
                var remainder = Math.Abs(number % 3);

                switch (remainder)
                {
                    case 0:
                    case 1:
                    case 2: arraysCurrentIndex[remainder]++; break;
                    default: numbers.RemoveAt(i); i--; break;
                }
            }

            for (int i = 0; i < arraysCurrentIndex.Length; i++)
            {
                jaggedArray[i] = new int[arraysCurrentIndex[i]];
                arraysCurrentIndex[i] = 0;
            }

            foreach (var number in numbers)
            {
                var remainder = Math.Abs(number % 3);
                jaggedArray[remainder][arraysCurrentIndex[remainder]] = number;
                arraysCurrentIndex[remainder]++;
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }

        }
    }
}
