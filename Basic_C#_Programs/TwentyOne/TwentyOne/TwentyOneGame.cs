using System;
using System.Collections.Generic;

namespace TwentyOne
{
    //A clas can only have one base class inherited, but it can inherit as many interfaces as it needs.
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        //this is an override method because is an abstract method in Game(we have to ahve an implementation of it)
        public override void Play()
        {
            //instantiate a dealer
            Dealer = new TwentyOneDealer();

            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }

            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your Bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; // this will not return anything, it will exit the Play method and continue the while loop one more time. And if teh balance is > then 0 and player.isActivelyPlaying is true, the play method will start again.
                }

                Bets[player] = bet;
            }

        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
