using System;

namespace AdditionalFeaturesAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1. Create a const variable.
            const string aVariable = "This is a const variable!";

            //2. Create a variable using the keyword "var.”
            var aImplicitlyTypedVariable = "And this is a var variable which the compiler determined the type.";

            Person person = new Person("Iron", "Man");// this will output fName : Iron and lName: Man
            Person unknownPerson = new Person(); // this will output fName : First name not provided and lName: Last name not provided

            Console.ReadLine();
        }
    }
}


//3. Chain two constructors together.
public class Person
{
    private string fName;
    private string lName;

    //Main constructor
    public Person(string firstName, string lastName)
    {
        fName = firstName;
        lName = lastName;
    }

    //Chained constructor
    public Person() : this("First name not provided", "Last name not provided")
    {
    }
}



