//Create a C# program that attempts to read from a file called `data.txt`. Handle
//exceptions that might occur, such as the file not being found
//(**FileNotFoundException**) or any other general exceptions. 
//Display a userfriendly message if the file is not found, 
//and ensure the program continues running gracefully.

using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            byte b = byte.Parse(args[0]);

            Console.WriteLine(b);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("No Argument");
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a Number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number Too Large");
        }
    }
}