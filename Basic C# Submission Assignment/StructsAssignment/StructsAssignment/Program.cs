using System;

namespace StructsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number number = new Number();
            number.Amount = 234.55m;

            //3. Print this amount to the console.
            Console.WriteLine(number.Amount);


            Console.ReadLine();
        }

        //1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
        public struct Number
        {
            public decimal Amount;
        }
    }
}
