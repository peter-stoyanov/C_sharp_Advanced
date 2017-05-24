using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(input));

        }

        static int GetFibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }
    }
}
