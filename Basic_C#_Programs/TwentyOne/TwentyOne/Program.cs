using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism, the ability of a class to morph into its inheriting class
            //Game game = new TwentyOneGame();

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jese", "Bill", "Bob" };
            game.ListPlayers();


            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
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
