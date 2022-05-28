using System;

namespace AbstractClassAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student".
            Person employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //Call the SayName() method on the object.
            employee.SayName();

            Console.ReadLine();
        }
    }
}
