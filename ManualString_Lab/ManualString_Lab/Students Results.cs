using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualString_Lab
{
    class StudentsResults
    {
        static void Main(string[] args)
        {
            //3
            //Gosho - 3.33333, 4.4444, 5.555

            int n = int.Parse(Console.ReadLine());


            NumberFormatInfo nfi = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = "."
            };

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                if (line.IndexOf('-') != -1)
                {
                    string[] tokens = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                    string student = tokens[0].Trim();

                    if (tokens[1].IndexOf(',') != -1)
                    {
                        string[] marks = tokens[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        double cAdv = double.Parse(marks[0].Trim(), CultureInfo.InvariantCulture);
                        double coop = double.Parse(marks[1].Trim(), CultureInfo.InvariantCulture);
                        double advOop = double.Parse(marks[2].Trim(), CultureInfo.InvariantCulture);
                        double average = (cAdv + coop + advOop) / 3.0;

                        if (i == 0)
                        {
                            Console.WriteLine(String.Format("{0, -10}|{1, 7}|{2, 7}|{3, 7}|{4, 7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));
                        }

                        //Console.WriteLine(String.Format(System.Globalization.CultureInfo.GetCultureInfo("bg-BG"), "{0, -10}|{1, 7:f2}|{2, 7:f2}|{3, 7:f2}|{4, 7:f4}|", student, cAdv, coop, advOop, average));
                        Console.WriteLine(String.Format("{0, -10}|{1, 7:f2}|{2, 7:f2}|{3, 7:f2}|{4, 7:f4}|", student, cAdv, coop, advOop, average));
                    }

                }

            }


        }
    }
}
