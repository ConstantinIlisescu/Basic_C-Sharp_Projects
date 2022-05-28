using System;

namespace AbstractClassAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////This is part of the Assignment Abstract Class
            ////5.Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student".
            //Person employee = new Employee() { firstName = "Sample", lastName = "Student" };

            ////Call the SayName() method on the object.
            //employee.SayName();


            //This is part of assignment Interfaces Assignment
            //Use polymorphism to create an object of type IQuittable
            IQuittable newEmployee = new Employee() { firstName = "Sample2", lastName = "Student2" };

            //Call the Quit() method on it.Hint: an object can be of an interface type if it implements that specific interface.
            newEmployee.Quit();



            Console.ReadLine();
        }
    }
}
