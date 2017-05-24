using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            int result = 0;
            int temp = 0;

            if (input != 0)
            {
                var stack = new Stack<int>();
                var stack2 = new Stack<int>();

                for (int i = 0; i <= input; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        result = stack.Aggregate((x, y) => x + y);
                        temp = stack.Pop();
                        stack.Clear();
                        stack.Push(temp);
                        stack.Push(result);
                    }
                }

                Console.WriteLine(result);

            }
        }
    }
}
