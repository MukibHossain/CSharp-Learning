//Question 2: Enumeration(Enum)
//A university grading system uses the grades A, B, C, D and F.
//Create an enum named Grade.
//Write a C# program that accepts a grade from the user and displays:
//A->Excellent, B->Very Good, C->Good, D->Pass, F->Fail. withhhhhhhhhh   DEFAULT

using System;

enum Grade
{
    A,
    B,
    C,
    D,
    F
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Grade: ");

        string x = Console.ReadLine().ToUpper();

        switch (x)
        {
            case "A":
                Console.WriteLine("Excellent");
                break;

            case "B":
                Console.WriteLine("Very Good");
                break;

            case "C":
                Console.WriteLine("Good");
                break;

            case "D":
                Console.WriteLine("Pass");
                break;

            case "F":
                Console.WriteLine("Fail");
                break;

            default:
                Console.WriteLine("Invalid Grade!");
                break;
        }
    }
}