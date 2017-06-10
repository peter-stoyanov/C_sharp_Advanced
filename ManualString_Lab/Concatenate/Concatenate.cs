﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate
{
    class Concatenate
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                sb.Append(line + " ");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
