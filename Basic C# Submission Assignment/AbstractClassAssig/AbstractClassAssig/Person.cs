namespace AbstractClassAssig
{
    //1.Create an abstract class called Person with two properties: string firstName and string lastName.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //2.Give it the method SayName().
        public abstract void SayName();

    }
}
