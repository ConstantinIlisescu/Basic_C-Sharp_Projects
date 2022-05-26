﻿using System.Collections.Generic;

namespace TwentyOne
{
    //Deck Object
    public class Deck
    {
        //Construct method always goes above the class. This is a method that is called as soon as an object is created.
        public Deck()
        {

            ////Adding one cart at a time
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);


            //adding all carts using a nested for each loop
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six" , "Seven" , "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }


        //Class property
        public List<Card> Cards { get; set; }
    }
}