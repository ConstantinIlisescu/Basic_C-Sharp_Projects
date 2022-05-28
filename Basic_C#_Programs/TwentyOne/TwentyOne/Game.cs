using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //an abstract method can only exist in an abstarct class, and must be defined in any inheriting class using "override" [public overide void Play()]
        public abstract void Play();

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
