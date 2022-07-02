using System;

namespace DatetimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Prints the current date and time to the console.
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            //2. Asks the user for a number.
            Console.WriteLine("Type a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.


            Console.WriteLine("The current time {0} + {1} hours equals {2}", currentDate, userInput, currentDate.AddHours(userInput));

            Console.ReadLine();
        }
    }
}
