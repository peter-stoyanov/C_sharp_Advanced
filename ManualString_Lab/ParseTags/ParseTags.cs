using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            //<upcase>yellow 

            string line = Console.ReadLine();

            int startSearchIndex = 0;

            while ( line.IndexOf("<upcase>") != -1 )
            {
                int start = line.IndexOf("<upcase>");
                int end = line.IndexOf("</upcase>");
                if (end > start)
                {
                    string oldstr = line.Substring(start, end + 9 - start);
                    string newstr = oldstr.ToUpper();
                    newstr = newstr.Remove(newstr.IndexOf("<UPCASE>"), 8);
                    newstr = newstr.Remove(newstr.IndexOf("</UPCASE>"), 9);
                    line = line.Replace(oldstr, newstr);
                }

                startSearchIndex++;
            }

            Console.WriteLine(line);

        }
    }
}
