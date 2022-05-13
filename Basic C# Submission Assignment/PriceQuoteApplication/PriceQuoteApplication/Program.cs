using System;

namespace PriceQuoteApplication
{
    internal class Program
    {
        static void Main()
        {

            //The first line of the program must be: Welcome to Package Express. Please follow the instructions below.
            Console.WriteLine("\nWelcome to Package Express. Please follow the instructions below.\n");


            //The user must then be prompted for the package weight.
            Console.Write("Please enter the package weight, in kg: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            //If the weight is greater than 50, display the error message: Package too heavy to be shipped via Package Express. Have a good day. At this point, the program will end.
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage to heavy to be shipped via Package Express. Have a good day.\n");
                return;
            }

            //The user must then be prompted for:
            //the package width
            Console.Write("\nPlease enter the package width, in cm: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            //the package height
            Console.Write("\nPlease enter the package height, in cm: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            //the package length
            Console.Write("\nPlease enter the package length, in cm: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //If the total of all dimensions is greater than 50, display the error message: Package too big to be shipped via Package Express. At this point, the program will end.
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("\nPackage to big to be shipped via Package Express.\n");
                return;
            }

            //Next, multiply the three dimensions (height, width, and length) together and multiply the product by the weight. Finally, divide the outcome by 100.
            float shipmentCost = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;

            //The result of this calculation is the price quote.Display the quote to the user as an amount in pounds sterling.
            Console.WriteLine("\nThe shipping cost is : £" + shipmentCost + " \n");


            //Stops the console from closing
            Console.Read();
        }
    }
}
