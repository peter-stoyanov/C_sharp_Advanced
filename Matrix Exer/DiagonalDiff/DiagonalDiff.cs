using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDiff
{
    class DiagonalDiff
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, rows];

            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < rows; j++)
            //    {
            //        if (i == j)
            //        {
            //            mainDiagonalSum += matrix[i, j];
            //        }

            //        if (j == rows - (i + 1))
            //        {
            //            secondaryDiagonalSum += matrix[i, j];
            //        }
            //    }
            //}

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mainDiagonalSum += matrix[i, i];
                secondaryDiagonalSum += matrix[i, (matrix.GetLength(0) - i) - 1];
            }


            Console.WriteLine(Math.Abs(mainDiagonalSum - secondaryDiagonalSum));
        }
    }
}
