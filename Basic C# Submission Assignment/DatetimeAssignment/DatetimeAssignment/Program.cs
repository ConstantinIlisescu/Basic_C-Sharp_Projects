using System;

namespace DatetimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            //2. Asks the user for a number.
            Console.WriteLine("Type a number");
            int userInput = Convert.ToInt32(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
