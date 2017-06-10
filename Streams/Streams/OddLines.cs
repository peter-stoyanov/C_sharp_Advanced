using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class OddLines
    {
        static void Main(string[] args)
        {
            ////prepare file with lines for the task
            //string prepareFile = "../../file.txt";

            //using (StreamWriter writer = new StreamWriter(prepareFile))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        writer.WriteLine($"{i} line");
            //    }
            //}

            string filepath = "../../file.txt";
            using (StreamReader reader = new StreamReader(filepath))
            {
                int counter = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}
