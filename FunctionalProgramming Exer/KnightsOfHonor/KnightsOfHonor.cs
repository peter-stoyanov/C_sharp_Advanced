﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Action<string> printer = (item) => Console.WriteLine("Sir " + item);

            var input = Console.ReadLine().Split(' ').ToList();

            foreach (var item in input)
            {
                printer(item);
            }
        }
    }
}
