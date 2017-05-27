using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithQueues
{
    class SequenceWithQueues
    {
        static void Main(string[] args)
        {

            int n = 3, p = 16; // todo
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                index++;
                if (current == p)
                {
                    Console.WriteLine("Index = {0}", index);
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }

        }
    }
}
