using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var triangle = new long[input][];

            for (int i = 0; i < input; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                if (i > 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == i)
                        {
                            triangle[i][j] = triangle[i - 1][j - 1];
                        }
                        else
                        {
                            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        }
                    }
                }
            }

            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                for (int j = 0; j < triangle[i].GetLength(0); j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
