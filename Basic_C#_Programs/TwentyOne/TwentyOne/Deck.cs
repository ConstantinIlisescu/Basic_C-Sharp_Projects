using System;
using System.Collections.Generic;

namespace TwentyOne
{
    //Deck Object
    public class Deck
    {
        //Construct method always goes above the class. This is a method that is called as soon as an object is created.
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

        }


        //Class property
        public List<Card> Cards { get; set; }


        //int times = 1 , is an optional parameter
        //out timesShuffled - needs to go before any optional parameters
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
