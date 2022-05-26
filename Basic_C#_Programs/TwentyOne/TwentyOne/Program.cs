using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            ////Named parameter
            //deck = Shuffle(deck: deck, times: 3);

            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled); // format string

            Console.ReadLine();
        }

        //int times = 1 , is an optional parameter
        //out timesShuffled - needs to go before any optional parameters
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }

        ////This is an overloaded method using the same method name as above
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;

        //}
    }
}
