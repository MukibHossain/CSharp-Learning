//Write a C# program that prompts the user to enter two integers. Perform a
//division of the two numbers and handle the **DivideByZeroException** if the user
//enters 0 as the denominator. Display an appropriate error message and ensure the
//program doesn’t crash.

using System;
class Program
{
    static void Main()
    {
        try
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double result = x / y;

            Console.WriteLine(result);
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("Denominator cannot be zero");
        }

        Console.WriteLine("Program Completed");
    }
}






