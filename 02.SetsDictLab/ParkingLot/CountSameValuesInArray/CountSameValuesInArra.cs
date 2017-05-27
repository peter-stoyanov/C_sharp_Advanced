using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => x.Replace(',','.'))
                .Select(x => decimal.Parse(x, CultureInfo.CurrentCulture))
                .ToList();

            var converted = numbers.ConvertAll(x => new { value = x, repeated = numbers.FindAll(y => y == x).Count });
            converted = converted.OrderBy(x => x.value).ToList();

            CultureInfo bg = new CultureInfo("bg-BG");

            foreach (var i in converted.Distinct())
            {
                if (i.repeated >= 1)
                {
                    var value = i.value.ToString().Replace('.',',');
                    Console.WriteLine($"{value} - {i.repeated} times");
                }
            }


        }
    }
}
