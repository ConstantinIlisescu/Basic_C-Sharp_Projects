using System;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Approval program for car insurance\n");

            //What is your age ?
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            //Have you ever had a DUI violation?[i.e., for driving under the influence of alcohol]
            Console.WriteLine("\nHave you ever had a DUI violation?[i.e., for driving under the influence of alcohol]\nPlease enter true or false:");
            bool DUIs = Convert.ToBoolean(Console.ReadLine());

            //How many speeding tickets have you had ?
            Console.WriteLine("\nHow many speeding tickets have you had?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());


            //Qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUIs.
            //Applicants must not have more than 3 speeding tickets.
            bool isQualifing = (userAge > 15 && DUIs && speedingTickets < 3);

            //Print the result of the Boolean expression created from the above business rules.
            Console.WriteLine("\nAre you qualified?\n" + isQualifing);
        }
    }
}
