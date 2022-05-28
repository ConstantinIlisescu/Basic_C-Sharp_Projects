using System;

namespace TwentyOne
{
    //A clas can only have one base class inherited, but it can inherit as many interfaces as it needs.
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
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
