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


    }
}

