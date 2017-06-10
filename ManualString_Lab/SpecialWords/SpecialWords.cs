using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialWords
{
    class SpecialWords
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string[] specialWords = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();

            foreach (var item in specialWords)
            {
                if (!wordsCount.Keys.Contains(item))
                {
                    wordsCount.Add(item, 0);
                }
            }

            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordsCount.Keys.Contains(word))
                {
                    wordsCount[word]++;
                }
            }

            foreach (var pair in wordsCount)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

        }
    }
}
