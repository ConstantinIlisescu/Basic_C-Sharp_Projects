using System;
using System.Collections.Generic;


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

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}


        //******** iterate over a int List using for each loop *******//

        //List<int> testScores = new List<int>();

        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}

        //******** iterate over a string List using for each loop *******//

        List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();
    }
}

