using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var inputQueuekData = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = inputNumbers[0];
            var s = inputNumbers[1];
            var x = inputNumbers[2];

            var queue = new Queue<int>(inputQueuekData);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
