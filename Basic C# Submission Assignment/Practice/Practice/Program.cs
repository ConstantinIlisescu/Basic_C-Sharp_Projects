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

            //casting num5 - is going to round down, loosing the value after .0
            int resultInt = num4 + (Int32)num5;
            Console.WriteLine(num4 + " + " + num5 + " = " + resultInt);


            //Math casting
            //This exemple will not compile:
            double num6 = 7.032320934;
            float num7 = 5.9f;
            // float totalFloat2 = num6 + num7;
            //Console.WriteLine(num6 + " + " + num7 + " = " + totalFloat2);

            //This example will compile
            double totalDouble = num6 + num7;
            Console.WriteLine(num6 + " + " + num7 + " = " + totalDouble); //A “float” is 32-bit and a “double” is 64-bit. In other words, a “float” is no more than 7 digits long, and a “double” is no more than 15-16 digits long. So a “double” is the more precise choice.
            //When the compiler converts a “float” to a “double” without being told to, this is called an “implicit conversion.”

            //“explicit conversion” on the “double” value.
            //This example code will successfully compile:
            float totalFloat3 = (float)num6 + num7;
            Console.WriteLine(num6 + " + " + num7 + " = " + totalFloat3);

            //There is no implicit conversion available from a “float” or “double” to a “decimal.” These conversions must be done “explicitly.” This is due solely to the nature of floats and decimals, which are encoded very differently than other number data types.
            //For example, you can implicitly cast from integer data types like “int” to a “decimal” this way:
            decimal num8 = 7.032320934m;
            int num9 = 5;
            decimal totalDecimal = num8 + num9;
            Console.WriteLine(num8 + " + " + num9 + " = " + totalDecimal);
            //Or
            sbyte num10 = 5;
            decimal totalDecimal2 = num8 + num10;
            Console.WriteLine(num8 + " + " + num10 + " = " + totalDecimal2);

            //Math with Strings  - “string concatenation”
            string firstName = "Jesse";
            string lastName = "Jhonson ";
            Console.WriteLine(firstName + " " + lastName);

            //Implicit conversion of data types:
            Console.WriteLine(firstName + " " + num9); //In the example, the compiler implicitly converted the “int” called “num9” to a string data type. 

            //Ternary operator
            int num11 = 11;
            int num12 = 5;

            string result = num11 > num12 ? "num11 is greater than num12" : "num11 is not greater than num12" ;
            Console.WriteLine(result);  


            //IF ELSE statements

            int currentTemperature = 70;
            int roomTemperature = 70;
            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.")
            }
            else // we can also use -> else if (a = b) - as many times as we need
            {
                Console.WriteLine("It is not exactly room temperature.")

            }



            Console.ReadLine();


        }
    }
}
