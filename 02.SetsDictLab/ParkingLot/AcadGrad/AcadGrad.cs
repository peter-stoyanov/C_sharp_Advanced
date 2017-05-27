using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadGrad
{
    class AcadGrad
    {
        static void Main(string[] args)
        {
            //3
            //Gosho
            //3.75 5   -->   Gosho is graduated with 4.375

            var n = int.Parse(Console.ReadLine());

            var dict = new SortedDictionary<string, decimal[]>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var numbers = Console.ReadLine()
                                    .Split(new char[] { ' ','\t','\n'}, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => decimal.Parse(x))
                                    .ToArray();

                dict.Add(name, numbers);
            }

            foreach (var student in dict)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }

        }
    }
}
