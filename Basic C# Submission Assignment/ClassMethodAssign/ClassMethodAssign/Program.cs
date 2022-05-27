using System;

namespace ClassMethodAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1.Create a class. In that class, create a void method that outputs an integer.
            *Have the method divide the data passed to it by 
            *4.Create a method with output parameters. - this is already completed in step 1
            */

            /*2.In the Main() method, instantiate that class.*/
            aClass aMath = new aClass();

            /*3.Have the user enter a number. Call the method on that number. 
             * Display the output to the screen. It should be the entered number, divided by two.*/

            Console.WriteLine("Enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result; // Need to define variable to hold the result
            aMath.mathOperation(5, out result);
            Console.WriteLine("Your number divided by 2 equals : {0}", result);



        }
    }


    /* 1.Create a class. In that class, create a void method that outputs an integer.
            *Have the method divide the data passed to it by 2.*/
    public class aClass
    {
        public void mathOperation(int input, out int finalResult)
        {

            finalResult = input / 2;

        }

        //5.Overload a method.
        //6.Declare a class to be static. A static class can be used as a convenient container for sets of methods that just operate on input parameters and do not have to get or set any internal instance fields. 
        public static void mathOperation(int input, int inputTwo, out int finalResult)
        {

            finalResult = input + inputTwo;
        }



    }


}
