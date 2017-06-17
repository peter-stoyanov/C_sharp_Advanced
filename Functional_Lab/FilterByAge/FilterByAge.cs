using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    people.Add(tokens[0], int.Parse(tokens[1]));
                }
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = Tester(condition, age);
            Action<KeyValuePair<string, int>> printer = Printer(format);

            PrintFilteredStudent(people, tester, printer);

        }

        public static void PrintFilteredStudent(Dictionary<string, int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }    
        }

        public static Func<int, bool> Tester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }

        public static Action<KeyValuePair<string, int>> Printer(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person =>
                       Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }
    }
}
