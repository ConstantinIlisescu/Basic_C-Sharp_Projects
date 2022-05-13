using System;

namespace LoopAssignment
{
    internal class Program
    {
        static void Main()
        {
            // 1.Do a Boolean comparison using a “while” statement.

            //Console.WriteLine("\nI will guess 5 numbers if they are odd or even.");

            //int rounds = 0;

            //while (rounds < 5)
            //{
            //    Console.WriteLine("\nType a number:");
            //    int userInput = Convert.ToInt32(Console.ReadLine());
            //    bool isTrue = userInput % 2 == 0;
            //    string result = isTrue ? "The number is even!" : "The number is odd!";
            //    Console.WriteLine(result);
            //    rounds++;
            //}


            // 2.Do a Boolean comparison using a “do while” statement.

            Console.WriteLine("\nI will guess 5 numbers if they are odd or even.");

            int rounds = 0;

            do
            {
                Console.WriteLine("\nType a number:");
                int userInput = Convert.ToInt32(Console.ReadLine());
                bool isTrue = userInput % 2 == 0;
                string result = isTrue ? "The number is even!" : "The number is odd!";
                Console.WriteLine(result);
                rounds++;
            }
            while (rounds < 5);
        }
    }
}
