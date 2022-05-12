using System;

namespace MathOperationAssignment
{
    internal class Program
    {
        static void Main()
        {
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console.
            //    Note: make sure your code can take inputs larger than 10,000,000.

            Console.WriteLine("Enter a number please:");
            long userInput = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Your number multiplied by 50 = " + 50 * userInput + "\n");


            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Enter another number please:");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number added to 25 = " + (25 + userInput2) + "\n");

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Enter another number please:");
            float userInput3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number divided by 12.5 = " + 12.5 / userInput3 + "\n");

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("Enter another number please:");
            bool userInput4 = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("Your number is grather than 50: " + userInput4 + "\n");


            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.WriteLine("Enter another number please:");
            int userInput5 = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("After dividing your number by 7, the reminder is: " + userInput5 + "\n");

        }
    }
}
