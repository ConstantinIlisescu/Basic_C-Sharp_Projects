using System;

namespace AbstractClassAssig
{

    //3.Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person, IQuittable
    {
        ////This is part of the Assignment Abstract Class
        //4.Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }


        //This is part of assignment Interfaces Assignment
        //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
        public void Quit()
        {

            Console.WriteLine("My name is {0}  {1} and I quit!", firstName, lastName);
        }

    }
}
