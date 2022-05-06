using System;

class Program
{
    static void Main()
    {
        // \n inserts a new line, as you would hit the ENTER key.
        Console.WriteLine("Pitman Training\nStudent Daily Report");


        Console.WriteLine("What course are you in?");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number?");
        short coursePage = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \" false\". ");
        bool anyHelp = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you'd like to share? Please provide specifics.");
        string positiveExperiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string otherFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        short hoursStudied = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Your course name is: " + courseName + "" +
                                        "\nYou are curently at page number: " + coursePage +
                                        "\nYour studied " + hoursStudied + " hours so far" +
                                        "\nYour positive experieces are: " + "\" " + positiveExperiences + " \"" +
                                        "\nYour other feedback is: " + "\" " + otherFeedback + " \"" +
                                        "\nThank you for your responses. An instructor will respond shortly. Have a great day!");
        Console.Read();


    }
}

