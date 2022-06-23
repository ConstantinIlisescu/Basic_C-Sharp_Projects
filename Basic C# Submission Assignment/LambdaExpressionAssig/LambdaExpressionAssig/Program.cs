using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees.
            //Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".

            List<Employee> employeeList = new List<Employee>();

            //ceate a list of first names
            List<string> firstNames = new List<string>()
            {
                "Joe", "Mary", "Joe", "Noah", "Jana", "Joe", "Cowley","Mark","Math","Kevan"
            };

            //ceate a list of last names
            List<string> lastNames = new List<string>()
            {
                "Buston", "Mars", "Mumbo", "Thunder", "Thumb","Rambo","Jackson","Randy","Zugenberg","Donald"
            };

            //ceate a list of IDs
            List<int> IDs = new List<int>()
            {
                1, 2, 3, 4, 5,6,7,8,9,10
            };

            //Add 10 employees to the employeeList.
            for (int i = 0; i < firstNames.Count; i++)
            {
                employeeList.Add(new Employee(firstNames[i], lastNames[i], IDs[i]));
            }


            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> employeeListJoe = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.firstName == "Joe")
                {
                    employeeListJoe.Add(employee);
                    Console.WriteLine(employee.firstName + " " + employee.lastName);
                }
            }

            Console.WriteLine();

            //3. Perform the same action again, but this time with a lambda expression.
            List<Employee> employeeListJoeLambda = employeeList.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee _employee in employeeListJoeLambda)
            {
                Console.WriteLine(_employee.firstName + " " + _employee.lastName);
            }

            Console.WriteLine();

            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> employeeListIdOver5 = employeeList.Where(x => x.ID > 5).ToList();
            foreach (Employee _employee in employeeListIdOver5)
            {
                Console.WriteLine(_employee.firstName + " " + _employee.lastName + " " + _employee.ID);
            }

            Console.ReadLine();
        }


        public class Employee
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int ID { get; set; }


            public Employee(string _firstName, string _lastName, int _ID)
            {
                firstName = _firstName;
                lastName = _lastName;
                ID = _ID;
            }
        }
    }
}
