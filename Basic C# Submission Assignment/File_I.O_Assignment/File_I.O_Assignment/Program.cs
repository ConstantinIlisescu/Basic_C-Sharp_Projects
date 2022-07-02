using System;
using System.IO;

namespace File_I.O_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Asks the user for a number.
            Console.WriteLine("Type a number.");

            //2. Logs that number to a text file.
            string userInput1 = Console.ReadLine();

            Console.WriteLine("\nType another number.");
            string userInput2 = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\coste\Desktop\userInputLogFile.txt", true))
            {
                file.WriteLine(userInput1);
                file.WriteLine(userInput2);
            }






            Console.ReadLine();
        }
    }
}
