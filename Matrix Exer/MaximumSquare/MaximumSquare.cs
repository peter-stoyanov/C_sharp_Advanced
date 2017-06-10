using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSquare
{
    class MaximumSquare
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            int sum = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    sum = 0;

                    //calculate 3x3 sub-matrix sum
                    for (int r = i; r < i + 3; r++)
                    {
                        for (int c = j; c < j + 3; c++)
                        {
                            sum += matrix[r, c];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                for (int j = bestCol; j < bestCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



    }
}
