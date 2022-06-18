using System;
using System.Collections.Generic;

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



            //Below is part of operators overload  assignment.
            Employee<int> employee1ID = new Employee<int>();
            employee1ID.ID = 1;

            Employee<int> employee2ID = new Employee<int>();
            employee2ID.ID = 1;

            //use the overloaded operator from the Employee Class, compare the IDs of the two employee instances and ConsoleWrite the answer.
            bool result = employee1ID == employee2ID;

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
