using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubicsAssault
{
    class CubicsAssault
    {
        static void Main(string[] args)
        {

            var input = string.Empty;
            var regions = new Dictionary<string, Dictionary<string, long>>();

            while ((input = Console.ReadLine()) != "Count em all")
            {
                var tokens = input
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                var region = tokens[0];
                var meteor = tokens[1];
                var meteorCount = long.Parse(tokens[2]);

                if (regions.ContainsKey(region))
                {
                    if (regions[region].ContainsKey(meteor))
                    {
                        regions[region][meteor] += meteorCount;
                    }
                    else
                    {
                        regions[region].Add(meteor, meteorCount);
                    }
                }
                else
                {
                    var meteors = new Dictionary<string, long>();
                    meteors.Add(meteor, meteorCount);
                    regions.Add(region, meteors);
                }
            }

            var orderedRegions = regions
                .OrderByDescending(pair => pair.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in orderedRegions)
            {
                var region = pair.Key;
                var meteors = pair.Value;
                var orderedMeteors = meteors
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);


                Console.WriteLine($"{region}");

                foreach (var nestedPair in orderedMeteors)
                {
                    var meteorType = nestedPair.Key;
                    var meteorCount = nestedPair.Value;
                    Console.WriteLine($"-> {meteorType} : {meteorCount}");
                }
            }



        }
    }
}
