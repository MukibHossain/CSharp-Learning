//Write a C# program to handle file opening errors.


using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 100 / num;
            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a number.");
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}