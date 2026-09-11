//A user enters two integers to perform a division operation. 
//The operation may fail during execution.
//Write a C# program to perform the division operation using try, catch, and (where appropriate) 
//finally to handle the exception gracefully and display a user-friendly message without crashing.
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator; // may throw DivideByZeroException
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            // Handles division by zero specifically
            Console.WriteLine("Error: Denominator cannot be zero.");
        }
        catch (FormatException)
        {
            // Handles non-numeric input
            Console.WriteLine("Error: Please enter valid whole numbers.");
        }
        finally
        {
            // Runs whether an exception occurred or not
            Console.WriteLine("Division operation attempt completed.");
        }

        Console.WriteLine("Program finished running.");
    }
}