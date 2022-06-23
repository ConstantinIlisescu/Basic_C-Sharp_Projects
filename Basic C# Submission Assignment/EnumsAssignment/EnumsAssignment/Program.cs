using System;

namespace EnumsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {





            //4.Wrap the statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            try
            {

                //2.Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter the curent day of the week, type it or enter the number (0 being monday)");
                string userInput = (Console.ReadLine());
                string userInputLowerCase = userInput.ToLower();



                //3.Assign the value to a variable of that enum data type you just created.
                daysOfTheWeeks day = (daysOfTheWeeks)Enum.Parse(typeof(daysOfTheWeeks), userInputLowerCase);        // reference : https://docs.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-6.0#system-enum-parse(system-type-system-string)

                Console.WriteLine("Your chosen current day is {0}", day);

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();
        }

        //1.Create an enum for the days of the week.
        public enum daysOfTheWeeks
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

    }
}







