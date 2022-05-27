using System;

namespace Classes_MethodsAsg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Create a class. In that class, create a void method that takes two integers as parameters. 
             * Have the method do a math operation on the first integer and display the second integer to the screen.*/

            /*2.In the Main() method of the console app, instantiate the class.*/
            aClass aMathOperation = new aClass();

            /*3.Call the method in the class, passing in two numbers.*/
            aMathOperation.mathOperation(3, 5);

            /*4.Call the method in the class, specifying the parameters by name.*/
            aMathOperation.mathOperation(numOne: 3, numTwo: 5);

        }
    }


    /*1.Create a class. In that class, create a void method that takes two integers as parameters. 
            * Have the method do a math operation on the first integer and display the second integer to the screen.*/
    public class aClass
    {
        public void mathOperation(int numOne, int numTwo)
        {
            int result = numOne * 10;
            Console.WriteLine("{0} multiply by 10 equals {1}", numOne, result);
        }
    }
}
