//1.Write a simple C# program that defines a delegate called PrintMessage which takes a string
//parameter and returns string. Then, implement a method DisplayMessage that prints a given
//message to the console. Create an instance of the delegate and use it to call the
//DisplayMessage method.

//Qs1:

using System;
class Program
{
    delegate string PrintMessage(string message);

    static string DisplayMessage(string message)
    {
        Console.WriteLine(message);
        return message;
    }

    static void Main()
    {
        PrintMessage p = DisplayMessage;

        p("Hello World");
    }
}

