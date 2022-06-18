using System;
using System.Collections.Generic;
using System.Linq;

namespace OprtOverloadingAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //3. Generics Assignment: Instantiate an Employee object with type "string" as its generic parameter. 
            Employee<string> employeeStringThings = new Employee<string>();

            //Assign a list of strings as the property value of Things.
            employeeStringThings.things = new List<string>() { "Bob", "Mark", "Judy" };

            //4. Generics Assignment: Instantiate an Employee object with type "int" as its generic parameter. 
            Employee<int> employeeIntThings = new Employee<int>();

            //Assign a list of integers as the property value of Things.
            employeeIntThings.things = new List<int>() { 19, 32, 44 };


            //5. Generics Assignment : Create a loop that prints all of the Things to the Console.
            Console.WriteLine("This is part of Generics assignment\n");

            // Reference : https://stackoverflow.com/questions/1955766/iterate-two-lists-or-arrays-with-one-foreach-statement-in-c-sharp
            foreach (var thing in employeeIntThings.things.Zip(employeeStringThings.things, Tuple.Create))
            {
                Console.WriteLine("{0} is {1} years old. ", thing.Item2, thing.Item1);
            }


            //Below is part of operators overload  assignment.
            Employee<int> employee1ID = new Employee<int>();
            employee1ID.ID = 1;

            Employee<int> employee2ID = new Employee<int>();
            employee2ID.ID = 1;

            //use the overloaded operator from the Employee Class, compare the IDs of the two employee instances and ConsoleWrite the answer.
            Console.WriteLine("\nBelow is part of the operators overloaded assignment");
            bool result = employee1ID == employee2ID;

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
