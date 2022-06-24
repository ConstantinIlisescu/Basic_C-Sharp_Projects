using System;

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
