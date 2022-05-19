using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        //1.Create a one-dimensional array of strings.Ask the user to select an index of the array and then display the string at that index on the screen.
        string[] stringArray = new string[] { "first array string", "second array string", "third array string", "fourth array string", "fifth array string" };
        Console.WriteLine("Type a number from 0 to 4, you will see the string stored at that index:");
        int input = Int32.Parse(Console.ReadLine());
        //Add in a message that displays when the user selects an index that doesn’t exist.
        if (input > stringArray.Length || input < 0)
        {
            Console.WriteLine("The number entered is longer//shorter then the array lenght\n");
        }
        else
        {
            Console.WriteLine("The array string stored at index " + input + " is: " + stringArray[input] + "\n");
        }



        //2.Create a one-dimensional array of integers.Ask the user to select an index of the array and then display the integer at that index on the screen.
        int[] intArray = new int[] { 20, 11, 23, 34, 32, 44 };
        Console.WriteLine("Type a number from 0 to 5, you will see the number stored at that index:");
        int input1 = Int32.Parse(Console.ReadLine());
        //3.Add in a message that displays when the user selects an index that doesn’t exist.
        if (input1 > intArray.Length || input1 < 0)
        {
            Console.WriteLine("The number entered is longer//shorter then the array lenght\n");
        }
        else
        {
            Console.WriteLine("The array integer stored at index " + input1 + " is: " + intArray[input1] + "\n");
        }


        //4.Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
        List<string> stringList = new List<string> { "first list string", "second list string", "third list string", "fourth list string", "fifth list string" };
        Console.WriteLine("Type a number from 0 to 4, you will see the string stored in this list at the index you selected:");
        int input2 = Int32.Parse(Console.ReadLine());
        //Add in a message that displays when the user selects an index that doesn’t exist.
        if (input1 > intArray.Length || input1 < 0)
        {
            Console.WriteLine("The number entered is longer//shorter then the list lenght\nPlease retry.");
        }
        else
        {
            Console.WriteLine("The list string stored at index " + input2 + " is: " + stringList[input2] + "\n");
        }

        //Prevent the console from closing.
        Console.ReadLine();
    }
}
