using System;

namespace Practice
{
    internal class Program
    {
        static void Main()
        {
            //Math operations


            int num1 = 7;
            int num2 = 3;
            int num3 = 12;

            //Add
            int total = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + total);

            //Subtraction
            int difference = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + difference);

            //Multiplication
            int product = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + product);

            //Division
            int quotient = num3 / num2;
            Console.WriteLine(num3 + " / " + num2 + " = " + quotient);

            //Reminder(Modulus)
            int remainder = num1 % num2;
            Console.WriteLine(num1 + " % " + num2 + " = " + quotient + "(reminder)");
            //To determinate if a number is even or odd , if output is 1 than the number is odd and if the output is 0 the number is even.
            int remainder2 = num1 % 2;

            //Math with different data types
            int num4 = 7;
            float num5 = 5.5f;

            float totalFloat = num4 + num5;
            Console.WriteLine(num4 + " + " + num5 + " = " + totalFloat);

            //cast num5 - is going to round down, loosing the value after .0
            int resultInt = num4 + (Int32)num5;
            Console.WriteLine(num4 + " + " + num5 + " = " + resultInt);


        }
    }
}
