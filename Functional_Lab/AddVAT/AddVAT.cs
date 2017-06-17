using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = (x) => x * 1.2m;

            var numbers = Console.ReadLine()
                .Split(',')
                //.Select(x => x.Replace(',', '.'))
                .Select(x => decimal.Parse(x, CultureInfo.CurrentCulture))
                .Select(addVAT)
                .ToList();

            numbers.ForEach(n => Console.WriteLine(n.ToString("f2")));

        }
    }
}
