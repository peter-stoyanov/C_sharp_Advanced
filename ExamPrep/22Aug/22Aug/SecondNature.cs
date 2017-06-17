using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Aug
{
    class SecondNature //30/100 - runtime error
    {
        static void Main(string[] args)
        {
            var inputFlowers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var flowersQueue = new Queue<int>(inputFlowers);
            var flowersSecondNatureQueue = new Queue<int>();

            var inputBuckets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bucketStack = new Stack<int>(inputBuckets);

            int tempBucket = 0;
            while (flowersQueue.Count > 0 && bucketStack.Count > 0)
            {
                int currentBucket = bucketStack.Pop();
                int currentFlower = flowersQueue.Peek();
                tempBucket += currentBucket;

                if (tempBucket > currentFlower)
                {
                    flowersQueue.Dequeue();
                    tempBucket -= currentFlower;
                }
                else if (tempBucket == currentFlower)
                {
                    flowersSecondNatureQueue.Enqueue(flowersQueue.Dequeue());
                    tempBucket -= currentFlower;
                }
                else
                {
                    continue;
                }
            }

            int bucketInLine = bucketStack.Pop();
            bucketStack.Push(bucketInLine + tempBucket);

            if (flowersQueue.Count > 0)
            {
                Console.WriteLine(string.Join(" ", flowersQueue));
            }
            else if (bucketStack.Count > 0)
            {
                Console.WriteLine(string.Join(" ", bucketStack));
            }

            string secondNatire = flowersSecondNatureQueue.Count > 0 ? string.Join(" ", flowersSecondNatureQueue) : "None";
            Console.WriteLine($"{secondNatire}");
        }
    }
}
