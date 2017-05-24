using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            var iterations = int.Parse(Console.ReadLine());

            if (iterations > 0)
            {
                var stack = new Stack<int>();

                for (int i = 0; i < iterations; i++)
                {
                    var command = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                    if (command.Length > 1)
                    {
                        stack.Push(command[1]);
                    }
                    else if (command[0] == 2)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine(stack.Max());
                    }
                }

            }

        }
    }
}
