namespace OprtOverloadingAssig
{
    public class Employee
    {
        //Solution reference on StackOverFlow: https://stackoverflow.com/questions/25461585/operator-overloading-equals

        public int ID { get; set; }
        public string employeeName { get; set; }

        public static bool operator ==(Employee A, Employee B)
        {
            if ((object)A == null)
                return (object)B == null;

            return A.Equals(B);
        }

        public static bool operator !=(Employee A, Employee B)
        {
            return !(A == B);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var employee = (Employee)obj;
            return (ID == employee.ID && employeeName == employee.employeeName);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ employeeName.GetHashCode();
        }



    }


}
