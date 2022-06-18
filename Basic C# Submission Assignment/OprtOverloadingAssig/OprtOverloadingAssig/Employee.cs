using System;

namespace OprtOverloadingAssig
{
    public class Employee<T>
    {

        //Overloading the == operator
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
