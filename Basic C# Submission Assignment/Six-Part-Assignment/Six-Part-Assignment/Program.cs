using System;
using System.Collections.Generic;
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
        string userInput = Console.ReadLine();

        //A loop that iterates through each string in the array and adds the user's text input to the end of each string.
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = elements[i] + userInput;
            //Then create a loop that prints off each string in the array on a separate line.
            Console.WriteLine(elements[i]);
        }
        Console.WriteLine("\n\n\n");
        //** END of Part 1 **//


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
        //** END of Part 2 **//



        //** Console App Assignment Part 3 **//
        // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n\n");

        //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n\n");
        //** END of Part 3 **//



        //** Console App Assignment Part 4 **//
        //A list of strings where each item in the list is unique.
        List<string> listOfStrings = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "j" };

        //Ask the user to input text to search for in the list.
        Console.WriteLine("Type a letter from 'a' to 'j'.");
        string userLetter = Console.ReadLine();

        //Add code to the loop that tells a user if they put in text that isn’t in the list.
        if (!listOfStrings.Contains(userLetter))
        {
            Console.WriteLine(userLetter + " is not in the list.");
            // Add code to the loop that stops it from executing once a match has been found.
            //return;
        }

        //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
        for (int i = 0; i < listOfStrings.Count; i++)
        {
            Console.WriteLine(i);
            if (listOfStrings[i].Equals(userLetter))
            {
                Console.WriteLine("Your letter is at index: " + i);
                //Add code to the loop that stops it from executing once a match has been found.
                //return;
            }

        }
        Console.WriteLine("\n\n\n");
        //** END of Part 4 **//



        //** Console App Assignment Part 5 **//
        //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
        List<string> listOfStrings1 = new List<string>() { "a", "a", "b", "b", "c", "d", "e", "f", "g" };
        Console.WriteLine("Type a letter from 'a' to 'g' ");
        string userLetter1 = Console.ReadLine();

        //Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
        for (int i = 0; i < listOfStrings1.Count; i++)
        {
            if (listOfStrings1[i].Equals(userLetter1))
            {
                Console.WriteLine("Your letter is present at index : " + i);
            }
        }

        //Add code to the loop that tells a user if they put in text that isn’t in the list.
        if (!listOfStrings1.Contains(userLetter1))
        {
            Console.WriteLine(userLetter1 + " is not in the list.");
        }
        Console.WriteLine("\n\n\n");
        //** END of Part 5 **//



        //** Console App Assignment Part 6 **//
        //Create a list of strings that has at least two identical strings in the list.
        List<string> listOfStrings2 = new List<string>() { "a", "a", "b", "b", "c", "d", "e", "f", "g" };

        //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        List<string> newList2 = new List<string>();
        foreach (string s in listOfStrings2)
        {
            //Console.WriteLine(s);
            if (newList2.Contains(s))
            {
                Console.WriteLine("The letter '" + s + "' is already in the list");
            }
            newList2.Add(s);
        }
        //** END of Part 6 **//

        Console.ReadLine();
    }
}

