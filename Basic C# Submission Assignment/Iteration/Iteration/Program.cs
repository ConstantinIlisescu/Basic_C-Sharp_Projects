using System;
//using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {

        //******** iterate over an int Array using for loop *******//

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}

        //******** iterate over a string Array using for loop *******//

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        for (int j = 0; j < names.Length; j++)
        {
            if (names[j] == "Jesse")
            {
                Console.WriteLine(names[j]);
            }
        }

        Console.ReadLine();
    }
}

