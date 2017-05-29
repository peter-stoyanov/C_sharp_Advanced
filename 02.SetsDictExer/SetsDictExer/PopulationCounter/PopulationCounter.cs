using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var populationAggregator = new Dictionary<string, Dictionary<string,int>>();

            var input = Console.ReadLine().Split('|').ToArray();
            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = int.Parse(input[2]);

                if (populationAggregator.ContainsKey(country))
                {
                    if (populationAggregator[country].ContainsKey(city))
                    {
                        populationAggregator[country][city] += population;
                    }
                    else
                    {
                        populationAggregator[country].Add(city, population);
                    }
                }
                else
                {
                    populationAggregator.Add(country, new Dictionary<string, int>() { { city, population } });
                }

                input = Console.ReadLine().Split('|').ToArray();
            }

            var sorted = populationAggregator.OrderByDescending(x => populationAggregator[x.Key].Values.Sum())
                .ToDictionary(pair => pair.Key, pair  => pair.Value);

            //OrderByDescending(x => sorted[country][x]).ToDictionary(pair => pair, pair => pair)
            foreach (var country in sorted.Keys)
            {
                sorted[country] = sorted[country].OrderByDescending(x => sorted[country][x.Key])
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            }


            foreach (var country in sorted.Keys)
            {
                Console.WriteLine($"{country} (total population: {sorted[country].Values.Sum()})");
                foreach (var city in sorted[country].Keys)
                {
                    Console.WriteLine($"=>{city}: {sorted[country][city]}");
                }
            }
        }
    }
}
