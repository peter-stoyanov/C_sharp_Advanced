using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest2x2
{
    class Biggest2x2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToList();
            int m = input[0];
            int n = input[1];

            int[,] matrix = new int[m, n];

            //read matrix
            for (int i = 0; i < m; i++)
            {
                var row = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToList();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            //calculate elements
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            int sum = 0;

            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }

            for (int i = bestRow; i < bestRow + 2; i++)
            {
                for (int j = bestCol; j < bestCol + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(bestSum);
        }
    }
}
