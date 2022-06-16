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
            employee2.ID = 2;
            employee2.employeeName = "Margarina";

            bool result = employee1.ID == employee2.ID;
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
