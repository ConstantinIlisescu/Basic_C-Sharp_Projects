using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }

        //an abstract method can only exist in an abstarct class, and must be defined in any inheriting class using "override" [public override void Play()]
        public abstract void Play(); // this has no implementation set

        //A virtual method cand only exist in an abstract class.
        //This method gets ingerited by an inheriting class but it has the ability to override it
        public virtual void ListPlayers()
        {
            //this has implementation set, but can be overrided
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
