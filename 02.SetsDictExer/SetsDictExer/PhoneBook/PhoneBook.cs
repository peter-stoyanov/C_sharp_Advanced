using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace resources
{
    class resources
    {
        static void Main(string[] args)
        {
            //Nakov - 0888080808
            //search
            //Mariika
            //Nakov
            //stop
            var resources = new Dictionary<string,string>();

            var input = Console.ReadLine();
            while (input != "search")
            {
                var entry = Regex.Split(input, "-");
                if (resources.ContainsKey(entry[0]))
                {
                    resources[entry[0]] = entry[1];
                }
                else
                {
                    resources.Add(entry[0], entry[1]);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "stop")
            {
                if (resources.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {resources[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                input = Console.ReadLine();
            }
        }
    }
}
