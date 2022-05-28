namespace InheritanceAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample"
            //and a last name of "Student".
            Employee person = new Employee() { FirstName = "Sample", LastName = "Student" };

            //5.Call the superclass method SayName() on the Employee object.
            person.SayName();
        }
    }
}
