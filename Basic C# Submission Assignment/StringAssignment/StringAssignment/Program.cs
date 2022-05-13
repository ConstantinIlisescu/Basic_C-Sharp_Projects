using System;
using System.Text;
namespace StringAssignment
{
    internal class Program
    {
        static void Main()
        {
            //1.Concatenate three strings.
            string string1 = "\nI am the first string, ";
            string string2 = "I am the second string, ";
            string string3 = "I am the third string - we are concatenated :)\n";
            Console.WriteLine(string1 + string2 + string3);

            //2.Convert a string to uppercase.
            Console.WriteLine(string1.ToUpper() + " now I am all uppercase.\n");

            //3.Create a StringBuilder and build a paragraph of text, one sentence at a time.
            string string4 = "I am the third string - now we were builded using the StringBuilder Class :)\n";
            StringBuilder buildedString = new StringBuilder(string1 + "\n");
            buildedString.Append(string2 + "\n");
            buildedString.Append(string4);
            Console.WriteLine(buildedString);


        }
    }
}
