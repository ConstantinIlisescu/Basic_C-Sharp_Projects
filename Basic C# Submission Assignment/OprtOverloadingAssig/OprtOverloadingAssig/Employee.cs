using System;
using System.Collections.Generic;

namespace OprtOverloadingAssig
{

    //1. Generics Assignment : Make the Employee class take a generic type parameter. <T> added
    public class Employee<T>
    {


        //2. Generics Assignment : Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
        public List<T> things { get; set; }




        //Below code is part of operators overload  assignment
        //Solution researched on StackOverFlow: https://stackoverflow.com/questions/25461585/operator-overloading-equals
        public int ID { get; set; }
        public string employeeName { get; set; }

        public static bool operator ==(Employee<T> A, Employee<T> B)
        {
            if (A.ID == B.ID)
                Console.WriteLine("The IDs are matching");
            else
                Console.WriteLine("The ID's are NOT matching");
            return A.ID == B.ID;
        }

        public static bool operator !=(Employee<T> A, Employee<T> B)
        {
            return !(A == B);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var employee = (Employee<T>)obj;
            return (ID == employee.ID && employeeName == employee.employeeName);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ employeeName.GetHashCode();
        }



    }


}
