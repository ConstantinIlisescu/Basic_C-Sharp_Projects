using System;
using System.IO;

namespace File_I.O_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\coste\Desktop\userInputLogFile.txt"; // enter your own file path
            //1. Asks the user for a number.
            Console.WriteLine("Type a number.");

            //2. Logs that number to a text file.
            string userInput1 = Console.ReadLine();

            Console.WriteLine("\nType another number.");
            string userInput2 = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(userInput1);
                file.WriteLine(userInput2);
            }

            // 3. Prints the text file back to the user.
            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine("You typed:");
                Console.WriteLine(sr.ReadToEnd());
            }






            Console.ReadLine();
        }
    }
}
