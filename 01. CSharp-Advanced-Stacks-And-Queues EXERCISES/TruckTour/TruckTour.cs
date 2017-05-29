using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<Station>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                queue.Enqueue(new Station() { Pump = tokens[0], DistanceToNext = tokens[1], Index = i });
            }

            int index = 0;
            int leftinTank = 0;

            while (leftinTank <= 0)
            {
                leftinTank = 0;

                Station nextStation = new Station();

                while (nextStation.Index != index)
                {
                    nextStation = queue.Dequeue();
                    queue.Enqueue(nextStation);
                    nextStation = queue.Peek();
                }

                for (int i = 0; i < n; i++)
                {
                    var currentStation = queue.Dequeue();

                    leftinTank = leftinTank + currentStation.Pump - currentStation.DistanceToNext;
                    if (leftinTank <= 0)
                    {
                        queue.Enqueue(currentStation);
                        break;
                    }

                    queue.Enqueue(currentStation);
                }

                index++;
            }

            Console.WriteLine(index - 1);
        }


    }

    class Station
    {
        public int Pump { get; set; }
        public int DistanceToNext { get; set; }
        public int? Index { get; set; }
        //public bool Visited { get; set; }
    }
}
