using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubics_Rube
{
    class Cubics_Rube
    {
        class Point
        {
            public long X { get; set; }
            public long Y { get; set; }
            public long Z { get; set; }
            public long Value { get; set; }
            public bool Changed { get; set; }
        }

        static void Main(string[] args)
        {
            var points = new List<Point>();

            var n = long.Parse(Console.ReadLine());

            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    for (long k = 0; k < n; k++)
                    {
                        points.Add(new Point()
                        {
                            X = i,
                            Y = j,
                            Z = k
                        });
                    }
                }
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Analyze")
            {
                long[] tokens = line
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                long x = tokens[0];
                long y = tokens[1];
                long z = tokens[2];
                long value = tokens[3];

                //this condition was not explicitly mentioned in the problem description
                if (value == 0) { continue; }

                var hit = points.Where(p => p.X == x && p.Y == y && p.Z == z).FirstOrDefault();

                if (hit != null)
                {
                    hit.Value = value;
                    hit.Changed = true;
                }

            }

            Console.WriteLine($"{points.Select(p => p.Value).ToArray().Sum()}");
            Console.WriteLine($"{points.Where(p => p.Changed == false).ToArray().Count()}");
        }
    }
}
