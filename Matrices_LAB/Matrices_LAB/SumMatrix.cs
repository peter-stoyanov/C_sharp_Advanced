using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_LAB
{
    class SumMatrix
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToList();
            int m = input[0];
            int n = input[1];

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                var row = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToList();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            //calculate elements
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i,j];
                }
            }

            ////print matrix with forEach
            //int index = 0;
            //foreach (int x in matrix)
            //{
            //    Console.Write(x + " ");
            //    index++;
            //    if (index % n == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
