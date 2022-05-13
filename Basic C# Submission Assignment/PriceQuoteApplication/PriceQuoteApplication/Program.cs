using System;

namespace PriceQuoteApplication
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\nWelcome to Package Express. Please follow the instructions below.\n");

            Console.Write("Please enter the package weight, in kg: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage to heavy to be shipped via Package Express. Have a good day.\n");
                return;
            }

            Console.Write("\nPlease enter the package width, in cm: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter the package height, in cm: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter the package length, in cm: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("\nPackage to big to be shipped via Package Express.\n");
                return;
            }

            float shipmentCost = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
            Console.WriteLine("\nThe shipping cost is : £" + shipmentCost + " \n");


        }
    }
}
