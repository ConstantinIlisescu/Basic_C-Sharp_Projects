using System;

namespace MethodAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Create a class. 
             * In that class, create three methods, each of which will take one integer parameter in and return an integer. 
             * The methods should do some math operation on the received parameter. 
             * Put this class in a separate .cs file in the application.  - it's in BasicMath.cs
             */
            BasicMath mathOperation = new BasicMath();

            //In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Tel me a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());


            //Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            int resultAdd = mathOperation.addNumber(userInput);
            Console.WriteLine("Your number added to 10 equals: " + resultAdd);

            int resultSubtract = mathOperation.subtractNumber(userInput);
            Console.WriteLine("Your number subtracted by 10 equals: " + resultSubtract);

            int resultMultiply = mathOperation.multiplyNumber(userInput);
            Console.WriteLine("Your number multiplied by 10 equals: " + resultMultiply);


            Console.ReadLine();
        }
    }
}
