using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            //Mimi Pepi Toshko
            //2

            var inputStringArr = Console.ReadLine().Split().ToArray();
            var nthToss = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(inputStringArr);

            while (queue.Count != 1)
            {
                for (int i = 1; i < nthToss; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
