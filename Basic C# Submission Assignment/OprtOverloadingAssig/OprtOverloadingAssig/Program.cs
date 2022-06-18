using System;

namespace OprtOverloadingAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.employeeName = "Bubulina";

            Employee employee2 = new Employee();
            employee2.ID = 1;
            employee2.employeeName = "Margarina";

            //use the overloaded operator from the Employee Class, compare the IDs of the two employee instances and ConsoleWrite the answer.
            bool result = employee1 == employee2;

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
