using System;

namespace ExceptionHandlingAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3. Exceptions handled using “try/catch.”
            try
            {

                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    //1. Ask the user for their age.
                    Console.WriteLine("What is your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }

                if (age <= 0) throw new LesThenZeroExceptipn();

                //2.Display the year the user was born.
                var currnetYear = DateTime.Now.Year;
                var bornYear = currnetYear - age;
                Console.WriteLine("You were born in {0}", bornYear);

                Console.ReadLine();
            }
            //4. Display appropriate error messages if the user enters zero or negative numbers.
            catch (LesThenZeroExceptipn)
            {
                Console.WriteLine("Your age must be greater then 0!");
                Console.ReadLine();
                return;
            }
            //5. Display a general message if an exception was caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("An error occured, please try again!");
                Console.ReadLine();
                return;
            }
        }
    }

    // Create my own excetion that inherits from Exception
    public class LesThenZeroExceptipn : Exception
    {
        public LesThenZeroExceptipn()
            : base() { }
        public LesThenZeroExceptipn(string message)
            : base(message) { }
    }

}
