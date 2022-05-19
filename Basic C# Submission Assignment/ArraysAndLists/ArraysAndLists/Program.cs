using System;

internal class Program
{
    static void Main()
    {

        //Array fundamentals
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        int[] numArray2 = { 5, 2, 10, 200, 5000 };

        numArray2[1] = 300;

        Console.WriteLine(numArray1[0]);
        Console.ReadLine();


    }
}

