using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPotato
{
    class MathPotato
    {
        static void Main(string[] args)
        {
            //Mimi Pepi Toshko
            //2
            //only in prime cycles

            var inputStringArr = Console.ReadLine().Split().ToArray();
            var nthToss = int.Parse(Console.ReadLine());
            int cycle = 1;

            var queue = new Queue<string>(inputStringArr);

            while (queue.Count != 1)
            {
                for (int i = 1; i < nthToss; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                
                // check if cycle is prime
                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;

            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }

    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
