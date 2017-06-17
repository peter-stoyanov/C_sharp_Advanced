using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDistrict
{
    class MapDistrict
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minimumPopulation = int.Parse(Console.ReadLine());

            var cities = input
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(pair =>
               {
                   var tokens = pair.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                   return new { District = tokens[0], Population = int.Parse(tokens[1]) };
                })
               .GroupBy(d => d.District)
               .Where(group => group.ToList().Select(i => i.Population).Sum() > minimumPopulation)
               .Select(group =>
                        new {
                            City = group.Key,
                            Districts = group.OrderByDescending(x => x.Population)
                        })
               .OrderByDescending(group => group.Districts.First().Population)
               .ToList();

            foreach (var city in cities)
            {
                Console.WriteLine($"{city.City}: {String.Join(" ", city.Districts.Select(d => d.Population).Take(5))}");
            }
        }
    }
}
