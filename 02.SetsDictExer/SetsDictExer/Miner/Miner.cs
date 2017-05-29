using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{
    class Miner
    {
        static void Main(string[] args)
        {
            //Gold
            //155
            //Silver
            //10

            var resources = new Dictionary<string, int>();

            var type = Console.ReadLine();

            while (type != "stop")
            {
                var qty = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(type))
                {
                    resources[type] += qty;
                }
                else
                {
                    resources.Add(type, qty);
                }

                type = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
