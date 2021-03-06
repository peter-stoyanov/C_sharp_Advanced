﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weak
{
    class Weak
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            var lines = new List<string>();

            while ((line = Console.ReadLine()) != "END")
            {
                lines.Add(line);
            }

            var students = lines
               .Select(pair =>
               {
                   var tokens = pair.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                   return new
                   {
                       FirstName = tokens[0],
                       LastName = tokens[1],
                       Marks = tokens.Skip(2).Select(int.Parse).ToList()
                   };
               })
               .ToList();

            students = students.Where(s => s.Marks.Where(m => m <= 3).Count() >= 2).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
