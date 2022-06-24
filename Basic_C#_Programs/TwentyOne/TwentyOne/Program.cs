using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //create player using the constructor
                Player player = new Player(playerName, bank);

                //polymorphism 
                Game game = new TwentyOneGame();

                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                //When while loop exits the game the player gets removed
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            //If the condition above is not "yes", this happens
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

        }
    }
}
