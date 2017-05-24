using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            //5 2 13
            //1 13 45 32 4

            var inputNumbers = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var inputStackData = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = inputNumbers[0];
            var s = inputNumbers[1];
            var x = inputNumbers[2];

            var stack = new Stack<int>(inputStackData);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
