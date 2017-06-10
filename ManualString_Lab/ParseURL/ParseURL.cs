using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            //https://softuni.bg/courses/csharp-advanced

            bool isValid = true;

            string line = Console.ReadLine();

            string protocol = string.Empty;
            string server = string.Empty;
            string resources = string.Empty;

            if (line.IndexOf("://") != -1)
            {
                string[] tokens = line.Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

                protocol = tokens[0].Trim();

                if (tokens.Length > 2)
                {
                    isValid = false;
                }
                else
                {
                    if (tokens[1].IndexOf("/") == -1)
                    {
                        isValid = false;
                    }
                    else
                    {
                        //string[] parts = line.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

                        server = tokens[1].Substring(0, tokens[1].IndexOf("/"));

                        resources = tokens[1].Substring(tokens[1].IndexOf("/") + 1);
                    }
                }

            }


            if (isValid)
            {
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
            else
            {
                Console.WriteLine("Invalid URL");
            }

        }
    }
}
