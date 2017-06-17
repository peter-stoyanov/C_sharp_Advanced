using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomBloom
{
    class BloomBloom
    {
        struct SeededFlowerCoord
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }

        static void Main(string[] args)
        {
            var inputGardenSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = inputGardenSize[0];
            int m = inputGardenSize[1];

            int[,] garden = new int[n, m];

            var seeded = new List<SeededFlowerCoord>();
            string inputSeedPlaces;
            while ((inputSeedPlaces = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                var seedingPlaces = inputSeedPlaces.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                seeded.Add(new SeededFlowerCoord { Row = seedingPlaces[0], Col = seedingPlaces[1] });
            }
            seeded.OrderBy(x => x.Row).ThenBy(x => x.Col);

            foreach (var seed in seeded)
            {
                HandleBloom(garden, seed);
            }









            //print
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void HandleBloom(int[,] garden, SeededFlowerCoord seed)
        {
            if (seed.Row >= 0 && seed.Row <= garden.GetLength(0) - 1)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    if (j != seed.Col)
                    {
                        garden[seed.Row, j] += 1;
                    }
                }
            }

            if (seed.Col >= 0 && seed.Col <= garden.GetLength(1) - 1)
            {
                for (int i = 0; i < garden.GetLength(0); i++)
                {
                    if (i != seed.Row)
                    {
                        garden[i, seed.Col] += 1;
                    }
                }
            }

            garden[seed.Row, seed.Col] += 1;
        }
    }
}
