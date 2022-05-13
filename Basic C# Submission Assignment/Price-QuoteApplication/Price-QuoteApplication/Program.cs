using System;
namespace Price_QuoteApplication
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\nWelcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter the package weight, in kg:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                break;
            }

        }
    }
}
