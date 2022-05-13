using System;

namespace Practice2
{
    internal class Program
    {
        static void Main()
        {
            //Switch statement
            //int number = 2;
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("The number is 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("The number is 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("The number is 3");
            //        break;
            //}

            //While loop
            Console.WriteLine("Guess a number from 1 to 100");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;


            while (!isGuessed)
            {

                switch (userNumber)
                {
                    case 29:
                        Console.WriteLine("You guessed 29, well done!");
                        isGuessed = true;
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55, well done!");
                        isGuessed = true;
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12, well done");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Not guessed...try again.");
                        Console.WriteLine("Guess another number from 1 to 100");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }




        }
    }
}
