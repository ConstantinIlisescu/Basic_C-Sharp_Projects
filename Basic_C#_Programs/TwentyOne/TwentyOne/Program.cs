using Casino;
using Casino.TwentyOne;
using System;
using System.Data;
using System.Data.SqlClient;
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

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithExceptions(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        UpdateDbWithExceptions(ex);
                        Console.ReadLine();
                        return;
                    }

                }

                //When while loop exits the game the player gets removed
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            //If the condition above is not "yes", this happens
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

        }

        private static void UpdateDbWithExceptions(Exception ex)
        {

            //This is the conection path to the dataBase.
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                                        MultiSubnetFailover=False";

            //This is a parameterized query and are a type of SQL query that requires at least one parameter (@ExceptionType, etc) for execution.
            //A placeholder is normally substituted for the parameter in the SQL query

            string queryString = @"INSERT INTO [Table] (ExceptionType, ExceptionMessage,TimeStamp) VALUES
                                                    (@ExceptionType, @ExceptionMessage,@TimeStamp)";

            //Creating a using statement to check and control the unmanaged code, or unmanaged resources. "using" helps protect from SQL injection attacks
            //The below block of code connects to an external connection and closes it once it finish, to free up the memory space or other resources.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                // define the SQL parameter a VarChar type.
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                //Update the value of the parameters
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();


            }

        }

    }
}
