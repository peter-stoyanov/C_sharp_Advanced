using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            var inputNum = int.Parse(Console.ReadLine());

            if (inputNum != 0)
            {
                var stack = new Stack<int>();

                while (inputNum != 0)
                {
                    stack.Push(inputNum % 2);
                    inputNum /= 2;
                }
            
                while (stack.Count != 0)
                {
                    Console.Write(stack.Pop());
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
