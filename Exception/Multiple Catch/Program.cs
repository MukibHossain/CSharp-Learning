//Create a C# program that attempts to read from a file called `data.txt`. Handle
//exceptions that might occur, such as the file not being found
//(**FileNotFoundException**) or any other general exceptions. 
//Display a userfriendly message if the file is not found, 
//and ensure the program continues running gracefully.
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string text = File.ReadAllText("data.txt");

            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception)
        {
            Console.WriteLine("Something went wrong.");
        }

        Console.WriteLine("Program Finished.");
    }
}