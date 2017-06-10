using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal2x2Squares
{
    class Equal2x2Squares
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            int row = input[0];
            int col = input[1];

            char[,] matrix = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                var rowData = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => (char)x[0]).ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rowData[j];
                }
            }

            int countEqual = 0;

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i + 1, j] == matrix[i + 1, j + 1] && matrix[i, j] == matrix[i + 1, j])
                    {
                        countEqual++;
                    }
                }
            }

            Console.WriteLine(countEqual);

            ////check print
            //int index = 0;
            //foreach (char x in matrix)
            //{
            //    Console.Write(x + " ");
            //    index++;
            //    if (index % col == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
