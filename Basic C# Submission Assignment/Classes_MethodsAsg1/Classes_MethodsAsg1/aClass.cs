using System;

namespace Classes_MethodsAsg1
{
    internal class aClass
    {

        /*1.Create a class. 
             * In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), 
             * then return the answer as an integer.*/
        public int aNumber(int userInput)
        {
            return userInput * 5;
        }


        /*3.Add a second method to the class with the same name that will take in a decimal, 
           * create a different math operation for it, then return the answer as an integer. */
        public decimal aNumber(decimal userinput)
        {
            return userinput + 5.1m;
        }

        /*5.Add a third method to the class, with the same name, that will take in a string, 
           * convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.  */
        public int aNumber(string userInput)
        {
            int userInputNumber = Convert.ToInt32(userInput);
            return userInputNumber - 10;
        }

    }
}
