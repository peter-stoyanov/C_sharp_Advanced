using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sequence
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(n);

            int index = 0;
            int[] results = new int[50];

            while (queue.Count > 0)
            {
                int element = queue.Dequeue();
                results[index] = element;
                index++;

                if (index == 50)
                {
                    break;
                }

                queue.Enqueue(element + 1);
                queue.Enqueue(2 * element + 1);
                queue.Enqueue(element + 2);

            }

            Console.WriteLine(String.Join(" ", results));
        }
    }
}
