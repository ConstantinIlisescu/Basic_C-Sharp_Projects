/*  **Using**  is a keyword that tells the compiler that you’ll be utilizing the System library.
    **System**  is the main namespace of the Base Class Library (a vast library of code that provides the most basic functionality of the C# language). 
    
*/
using System;

// class SampleApplication  instructs the compiler that anything between curly braces { } is part of the class named SampleApplication.In this case, a class is simply an organized grouping of code.
class SampleApplication
{
    // static  is a keyword used as a type of modifier for the Main() function.It refers to itself rather than creating an instance of the class it’s modifying.It tells the compiler that this function can be called without relying on reference to an object.
    // void  is another modifier of the Main() function. It tells the compiler that this function isn’t going to return a value. Instead, it’s just going to perform an action (like printing words to the console).
    // Main()  is a function that tells the compiler to execute anything between the curly braces. In a console application, a function with the name “Main()” is automatically executed as the first step in running the program.
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}