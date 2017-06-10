using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string wordsFile = "../../words.txt";
            string textFile = "../../text.txt";
            string resultFile = "../../result.txt";

            var words = new List<string>();
            using (StreamReader wordsReader = new StreamReader(wordsFile))
            {
                string line;
                while ((line = wordsReader.ReadLine()) != null)
                {
                    words.AddRange(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
                }
                words = words.Select(x => Regex.Replace(x, @"[^\w]", string.Empty)).ToList();
            }

            var text = new List<string>();
            using (StreamReader textReader = new StreamReader(textFile))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    text.AddRange(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
                }
                text = text.Select(x => Regex.Replace(x, @"[^\w]", string.Empty)).ToList();
            }

            var commonWordsCounter = new Dictionary<string, int>();

            foreach (var word in words.Distinct())
            {
                if (text.Contains(word))
                {
                    int repeated = text.FindAll(x => x.ToLower() == word.ToLower()).ToList().Count;

                    if (!commonWordsCounter.ContainsKey(word))
                    {
                        commonWordsCounter.Add(word, repeated);
                    }
                }
            }

            commonWordsCounter = commonWordsCounter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


            using (StreamWriter resultWriter = new StreamWriter(resultFile))
            {
                foreach (var word in commonWordsCounter)
                {
                    resultWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }


        }
    }
}
