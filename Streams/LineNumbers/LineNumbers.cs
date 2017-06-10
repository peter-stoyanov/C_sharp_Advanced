using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            ////prepare file for the task
            //string prepareFile = "../../fileWithoutLineNumbers.txt";

            //using (StreamWriter writer = new StreamWriter(prepareFile))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        writer.WriteLine(RandomString(10));
            //    }
            //}

            string inputfile = "../../fileWithoutLineNumbers.txt";
            string outputfile = "../../fileWithLineNumbers.txt";

            using (StreamReader reader = new StreamReader(inputfile))
            {
                using (StreamWriter writer = new StreamWriter(outputfile))
                {
                    int counter = 1;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(String.Format($"{counter} {line}"));
                        counter++;
                    }

                }
            }
        }
    }
}
