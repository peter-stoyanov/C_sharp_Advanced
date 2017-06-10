using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Exer
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            int row = input[0];
            int col = input[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


            string[,] matrix = new string[row, col];

            int offestColumns = 0;
            int offestRows = 0;

            for (int i = 0; i < row; i++)
            {
                string firstLetter = alphabet[offestRows].ToString();
                string thirdLetter = alphabet[offestRows].ToString();

                for (int j = 0; j < col; j++)
                {
                    string secondLetter = alphabet[j + offestColumns].ToString();
                    matrix[i, j] = firstLetter + secondLetter + thirdLetter;
                }
                offestColumns++;
                offestRows++;
            }

            //print matrix with forEach
            int index = 0;
            foreach (string x in matrix)
            {
                Console.Write(x + " ");
                index++;
                if (index % col == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
