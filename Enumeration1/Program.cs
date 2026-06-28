//Question 2: Enumeration(Enum)
//A university grading system uses the grades A, B, C, D and F.
//Create an enum named Grade.
//Write a C# program that accepts a grade from the user and displays:
//A->Excellent, B->Very Good, C->Good, D->Pass, F->Fail.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Grade
{
    A, B, C, D, F
}
class Program
{
    static void Main()
    {
        Console.Write("Enter Grade (A/B/C/D/F: ");
        string input = Console.ReadLine().ToUpper();

        Grade grade;

        if (Enum.TryParse(input, out grade))
        {
            switch (grade)
            {
                case Grade.A:
                    Console.WriteLine("Excelent");
                    break;

                case Grade.B:
                    Console.WriteLine("Very Good");
                    break;

                case Grade.C:
                    Console.WriteLine("Good");
                    break;
                case Grade.D:
                    Console.WriteLine("Pass");
                    break;
                case Grade.F:
                    Console.WriteLine("Fail");
                    break;
            }
        }

    }
   
}





