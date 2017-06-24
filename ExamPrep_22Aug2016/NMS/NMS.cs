using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS
{
    class NMS
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string line;
            while ((line = Console.ReadLine()) != "---NMS SEND---")
            {
                sb.Append(line);

            }

            string delimiter = Console.ReadLine();

            char previous = '\0';
            int counter = 0;
            foreach (var letter in sb.ToString().ToLower().ToCharArray())
            {
                if (previous != '\0' && (int)letter < (int)previous)
                {
                    sb.Insert(counter, delimiter);
                    previous = letter;
                    counter = counter + delimiter.Length + 1;
                }
                else
                {
                    previous = letter;
                    counter++;
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
