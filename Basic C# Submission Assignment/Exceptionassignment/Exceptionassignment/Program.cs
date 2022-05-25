using System;
using System.Collections.Generic;

namespace Exceptionassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Create a list of integers.
            List<int> list = new List<int>() { 238, 333, 745 };

            ////Ask the user for a number to divide each number in the list by.
            Console.WriteLine("Pick a number");
            //int userNum = Convert.ToInt32(Console.ReadLine());

            ////Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item + " devided by " + userNum + " equals " + (item / userNum));
            //}

            ////Run the code, entering in non - zero numbers as the user.Look at the displayed results.
            //// **** it works fine

            ////Run the code again, entering in zero as the number to divide by. Note any error messages you get.
            //// **** it shows "System.DivideByZeroException: 'Attempted to divide by zero.'"

            ////Run the code once again, entering in a string as the number to divide by. Note any error messages you get.
            //// **** it shows "System.FormatException: 'Input string was not in a correct format.'"


            ///*Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program 
            // * print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
            // * In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string.
            // * Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
            // */

            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int item in list)
                {
                    Console.WriteLine(item + " devided by " + userNum + " equals " + (item / userNum));
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't enter 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter only whole numbers.");
            }
            finally
            {
                Console.WriteLine("The finally block gets executed even if an error occurs");
            }


            Console.ReadLine();
        }
    }
}
