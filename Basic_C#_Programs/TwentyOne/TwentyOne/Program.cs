﻿using Casino;
using Casino.TwentyOne;
using System;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //create player using the constructor
                Player player = new Player(playerName, bank);

                //add a global unique identifier to each player
                player.Id = Guid.NewGuid();

                //log the 
                using (StreamWriter file = new StreamWriter(@"C:\Users\coste\OneDrive\Programing_and_WebDev_folder\Software Developer\Basic_C-Sharp_Projects\Basic_C#_Programs\TwentyOne\TwentyOne\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

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
