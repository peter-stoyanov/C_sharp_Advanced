using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            var stack = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++)
            {
                stack.Push(inputString[i]);
            }

            //stack.Count is being reduced with every Pop() so cant be used for traversing
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();

        }
    }
}
