using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            //Pesho: 2C, 4H, 9H, AS, QS

            var userCards = new Dictionary<string, HashSet<string>>();
            var userScores = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var tokens = input.Split(':').ToArray();
                var user = tokens[0];
                var cards = tokens[1].Split(',').Select(x => x.Trim()).ToArray();

                if (userCards.ContainsKey(user))
                {
                    userCards[user].UnionWith(cards);
                }
                else
                {
                    userCards.Add(user, new HashSet<string>(cards));
                    userScores.Add(user, 0);
                }

                input = Console.ReadLine();
            }

            foreach (var user in userCards)
            {
                int userScore = 0;

                foreach (var card in user.Value)
                {
                    var chars = card.ToCharArray();
                    var type = ((char)chars.Last()).ToString();
                    var candidateChars = chars.Take(chars.Length - 1).ToArray();
                    string candidate;
                    if (candidateChars.Count() == 1)
                    {
                        candidate = candidateChars[0].ToString();
                    }
                    else
                    {
                        candidate = String.Concat(candidateChars);
                    }
                    int cardTypescore = 1;
                    int cardPowerScore;
                    int cardScore;

                    var isDigit = int.TryParse(candidate, out cardPowerScore);
                    if (!isDigit)
                    {
                        switch (candidate)
                        {
                            case "J":
                                cardPowerScore = 11;
                                break;
                            case "Q":
                                cardPowerScore = 12;
                                break;
                            case "K":
                                cardPowerScore = 13;
                                break;
                            case "A":
                                cardPowerScore = 14;
                                break;
                        }
                    }
                    switch (type)
                    {
                        case "S":
                            cardTypescore = 4;
                            break;
                        case "H":
                            cardTypescore = 3;
                            break;
                        case "D":
                            cardTypescore = 2;
                            break;
                        case "C":
                            cardTypescore = 1;
                            break;
                    }

                    cardScore = cardPowerScore * cardTypescore;
                    userScore += cardScore;
                }

                userScores[user.Key] = userScore;
            }

            foreach (var user in userScores)
            {
                Console.WriteLine($"{user.Key}: {user.Value}");
            }

        }
    }
}
