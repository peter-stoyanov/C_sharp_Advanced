using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AshesRoses
{
    class AshesRoses
    {
        static void Main(string[] args)
        {
            //Grow <Dorne> <Indigo> 2000

            var input = string.Empty;
            var regions = new Dictionary<string, Dictionary<string, int>>();

            string pattern = @"^Grow <([A-Z][a-z]+)> <([a-zA-Z0-9]+)> ([0-9]{1,10})$";
            Regex rgx = new Regex(pattern);


            while ((input = Console.ReadLine()) != "Icarus, Ignite!")
            {
                if (rgx.Match(input).Success)
                {
                    var match = rgx.Match(input);
                    var region = match.Groups[1].Value;
                    var color = match.Groups[2].Value;
                    var roses = int.Parse(match.Groups[3].Value);

                    if (regions.ContainsKey(region))
                    {
                        if (regions[region].ContainsKey(color))
                        {
                            regions[region][color] += roses;
                        }
                        else
                        {
                            regions[region].Add(color, roses);
                        }
                    }
                    else
                    {
                        var newRoses = new Dictionary<string, int>();
                        newRoses.Add(color, roses);
                        regions.Add(region, newRoses);
                    }
                }
            }

            var orderedRegions = regions
                .OrderByDescending(pair => pair.Value.Values.Sum())
                .ThenBy(pair => pair.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in orderedRegions)
            {
                var region = pair.Key;
                var colors = pair.Value;
                var orderedColors = colors
                    .OrderBy(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);


                Console.WriteLine($"{region}");

                foreach (var nestedPair in orderedColors)
                {
                    var color = nestedPair.Key;
                    var roseAmount = nestedPair.Value;
                    Console.WriteLine($"*--{color} | {roseAmount}");
                }
            }


        }
    }
}
