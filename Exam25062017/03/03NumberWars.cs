using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03NumberWars
{
    public class NumberWars
    {
        public class Card
        {
            public int Number { get; set; }
            public string Char { get; set; }
            public int CharValue { get; set; }
            public int CombinedValue { get; set; }
        }

        private static bool IsDigit(char token)
        {
            return Char.IsDigit(token);
        }

        public static Card GetCard(string input)
        {
            //45s
            var pattern = @"^([0-9]+)([a-zA-Z]{1})$";
            var match = Regex.Match(input, pattern);

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            if (match.Success)
            {
                int cardNumber = int.Parse(match.Groups[1].Value);
                string cardLetter = match.Groups[2].Value;
                return new Card()
                {
                    Number = cardNumber,
                    Char = cardLetter,
                    CharValue = alphabet.IndexOf(cardLetter.ToLower()) + 1,
                    CombinedValue = cardNumber + alphabet.IndexOf(cardLetter.ToLower()) + 1
                };
            }
            else
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            //20y 28j 45s 21i 81i
            //26z 9f 80a 68g 67z

            var _1stplayerCards = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var _2ndplayerCards = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var deck1 = new Queue<Card>();
            var deck2 = new Queue<Card>();

            foreach (var item in _1stplayerCards)
            {
                deck1.Enqueue(GetCard(item));
            }
            foreach (var item in _2ndplayerCards)
            {
                deck2.Enqueue(GetCard(item));
            }

            int turns = 0;
            bool firstPlayerWins = false;
            bool hasWinner = false;
            bool isDraw = false;

            while (hasWinner == false)
            {
                
                //new turn starts
                var _1stplayerList = new List<Card>();
                var _2ndplayerList = new List<Card>();
                var cardsOnField = new List<Card>();

                if (turns == 1000000)
                {
                    //count cards
                    if (deck1.Count > deck2.Count)
                    {
                        hasWinner = true;
                        firstPlayerWins = true;
                        break;
                    }
                    else if(deck1.Count < deck2.Count)
                    {
                        hasWinner = true;
                        firstPlayerWins = false;
                        break;
                    }
                    else
                    {
                        isDraw = true;
                        break;
                    }
                }
                else
                {
                    if (deck1.Count == 0)
                    {
                        hasWinner = true;
                        firstPlayerWins = false;
                        break;
                    }
                    if (deck2.Count == 0)
                    {
                        hasWinner = true;
                        firstPlayerWins = true;
                        break;
                    }
                    var _1stPlayerCard = deck1.Dequeue();
                    var _2ndPlayerCard = deck2.Dequeue();

                    cardsOnField.Add(_1stPlayerCard);
                    cardsOnField.Add(_2ndPlayerCard);

                    if (_1stPlayerCard.Number > _2ndPlayerCard.Number)
                    {
                        foreach (var fieldCard in cardsOnField.OrderByDescending(c => c.CombinedValue).ToList())
                        {
                            deck1.Enqueue(fieldCard);
                        }
                    }
                    else if(_2ndPlayerCard.Number > _1stPlayerCard.Number)
                    {
                        foreach (var fieldCard in cardsOnField.OrderByDescending(c => c.CombinedValue).ToList())
                        {
                            deck2.Enqueue(fieldCard);
                        }
                    }
                    else
                    {
                        //war
                        bool hasWarWinner = false;

                        var _1stplayerShownCards = new List<Card>();
                        var _2ndplayerShownCards = new List<Card>();

                        _1stplayerShownCards.Add(_1stPlayerCard);
                        _2ndplayerShownCards.Add(_2ndPlayerCard);

                        while (!hasWarWinner)
                        {
                            if (deck1.Count < 3)
                            {
                                hasWinner = true;
                                firstPlayerWins = false;
                                break;
                            }
                            if (deck2.Count < 3)
                            {
                                hasWinner = true;
                                firstPlayerWins = true;
                                break;
                            }

                            _1stplayerShownCards.Add(deck1.Dequeue());
                            _1stplayerShownCards.Add(deck1.Dequeue());
                            _1stplayerShownCards.Add(deck1.Dequeue());

                            _2ndplayerShownCards.Add(deck2.Dequeue());
                            _2ndplayerShownCards.Add(deck2.Dequeue());
                            _2ndplayerShownCards.Add(deck2.Dequeue());

                            cardsOnField.AddRange(_1stplayerShownCards);
                            cardsOnField.AddRange(_2ndplayerShownCards);

                            if (_1stplayerShownCards.Select(c => c.CharValue).Sum() > _2ndplayerShownCards.Select(c => c.CharValue).Sum())
                            {
                                foreach (var fieldCard in cardsOnField.OrderByDescending(c => c.CombinedValue).ToList())
                                {
                                    deck1.Enqueue(fieldCard);
                                    hasWarWinner = true;
                                    break;
                                }
                            }
                            else if (_1stplayerShownCards.Select(c => c.CharValue).Sum() > _1stplayerShownCards.Select(c => c.CharValue).Sum())
                            {
                                foreach (var fieldCard in cardsOnField.OrderByDescending(c => c.CombinedValue).ToList())
                                {
                                    deck2.Enqueue(fieldCard);
                                    hasWarWinner = true;
                                    break;
                                }
                            }
                            //else
                            //{
                            //    //draw from cards shown
                            //    isDraw = true;
                            //    break;
                            //}

                        }
                    }
                }

                turns++;
            }

            if (hasWinner)
            {
                if (firstPlayerWins)
                {
                    Console.WriteLine($"First player wins after {turns} turns");
                }
                else
                {
                    Console.WriteLine($"Second player wins after {turns} turns");
                }
            }
            else
            {
                Console.WriteLine($"Draw after {turns} turns");
            }








        }
    }
}