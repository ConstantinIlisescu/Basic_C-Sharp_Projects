using System;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            //Print to console the program name
            Console.WriteLine("Anonymous Income Comparison Program" + "\n");

            //Person 1
            Console.WriteLine("Person 1");

            Console.Write("Please enter your Hourly Rate: ");
            byte hourlyRate1 = Convert.ToByte(Console.ReadLine()); //Store the Input for Hourly Rate

            Console.Write("Please enter your Hours Worked Per Week: ");
            byte hoursPerWeek1 = Convert.ToByte(Console.ReadLine()); //Store the Input fro Hours per week

            //Person 2
            Console.WriteLine("\n" + "Person 2");

            Console.Write("Please enter your Hourly Rate: ");
            byte hourlyRate2 = Convert.ToByte(Console.ReadLine()); //Store the Input for Hourly Rate

            Console.Write("Please enter your Hours Worked Per Week: ");
            byte hoursPerWeek2 = Convert.ToByte(Console.ReadLine()); //Store the Input fro Hours per week

            //Annual salary of Person 1:
            int totalSalaryP1 = hourlyRate1 * hoursPerWeek1 * 52;
            Console.WriteLine("\nPerson 1 makes : " + totalSalaryP1 + " per year.\n");

            //Annual salary of Person 2:
            int totalSalaryP2 = (hourlyRate2 * hoursPerWeek2 * 52);
            Console.WriteLine("Person 2 makes : " + totalSalaryP2 + " per year.\n");

            //Person 1 makes more money than Person 2
            Console.WriteLine("Person 1 makes more money then Person 2 : " + (totalSalaryP1 > totalSalaryP2));

        }
    }
}
