using System;
//using System.Collections.Generic;



internal class Program
{
    static void Main(string[] args)
    {

        //** Console App Assignment Part 1 **//
        //A one-dimensional array of strings.
        string[] elements = { "Have Fun ", "Be Positive ", "Keep coding " };

        //Ask the user to input some text.
        Console.WriteLine("Type your name.\n");
        string userIntput = Console.ReadLine();

        //A loop that iterates through each string in the array and adds the user's text input to the end of each string.
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = elements[i] + userIntput;
            //Then create a loop that prints off each string in the array on a separate line.
            Console.WriteLine(elements[i]);
        }

        Console.WriteLine("\n\n\n");


        //** Console App Assignment Part 2 **//
        //An infinite loop.
        //for (int i = 0; true; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Save your code.
        //Fix the infinite loop so that it will execute properly.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(1);
        }

        Console.WriteLine("\n\n\n");

        //** Console App Assignment Part 3 **//
        // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n\n\n");

        //Save and execute your code.
        //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        //Save and execute your code.

        Console.WriteLine("\n\n\n");



        Console.ReadLine();
    }
}

