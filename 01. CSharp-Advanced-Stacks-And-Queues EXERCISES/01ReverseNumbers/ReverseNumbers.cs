using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var inputNumbers = new int[] { };

            if (input != String.Empty)
            {
                inputNumbers = input.Split().Select(x => int.Parse(x)).ToArray();
            }

            if (inputNumbers.Length != 0)
            {
                var stack = new Stack<int>(inputNumbers);

                while (stack.Count != 0)
                {
                    Console.Write(stack.Pop() + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
