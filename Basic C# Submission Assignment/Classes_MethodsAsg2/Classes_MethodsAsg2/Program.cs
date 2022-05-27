using System;

namespace Classes_MethodsAsg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Create a class. In that class, create a method that takes two integers as parameters. 
             * Make one of them optional. Have the method do a math operation and return an integer result.  */

            /*2.In the Main() method of the console app, instantiate the class. */
            aClass mathOperation = new aClass();

            //3. Ask the user to input two numbers, one at a time. 
            Console.WriteLine("Enter a number.");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            //Let them know they need not enter anything for the second number.
            Console.WriteLine("\nYou have the option to enter anoter number or to not enter anything.");
            string optionalInput = Console.ReadLine();
            int secondNum = optionalInput.Length == 0 ? 0 : Convert.ToInt32(optionalInput);

            /*4.Call the method in the class, passing in the one or two numbers entered.*/

            if (secondNum == 0)
            {
                Console.WriteLine("You typed the number: " + mathOperation.addTwoNum(firstNum) + " and didn't entered another number.");
            }
            else
            {
                int result = mathOperation.addTwoNum(firstNum, secondNum);
                Console.WriteLine("{0} plus {1} equals {2}", firstNum, secondNum, result);
            }

            /*5.Try various combinations of numbers on the code, including having no second number.*/

        }
    }
}
