using System;

namespace InheritanceAssig
{
    //1.Create a class called Person
    internal class Person
    {
        //Give it two properties, each of data type string. One called FirstName, the other LastName.
        public string FirstName;
        public string LastName;

        //2.Give this class a void method called SayName() that takes no parameters
        //and simply writes the person's full name to the console in the format of: "Name: [full name]".
        public void SayName()
        {
            Console.WriteLine("Name : {0} {1}.", FirstName, LastName);
        }
    }
}
