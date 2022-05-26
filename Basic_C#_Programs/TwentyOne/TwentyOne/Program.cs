using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
        }
    }
}
