//University Student Marks System
//This program reads the number of students and their marks into an integer array, lets the user look up a student's marks by index, and calculates the average. Three distinct exception types are handled in separate catch blocks, and a finally block always runs at the end.
//Design Summary
//FormatException: caught when the user enters non-numeric text for the student count, marks, or index.
//IndexOutOfRangeException: caught when the entered student index is outside the array bounds.
//DivideByZeroException: caught when computing the average with zero students (division by marks.Length == 0).
//finally block: always prints "Result processing completed." regardless of whether an exception occurred.

using System;
 
namespace UniversityMarksSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = null;

            try
            {
                Console.Write("Enter the number of students: ");
                int numberOfStudents = int.Parse(Console.ReadLine());

                marks = new int[numberOfStudents];

                for (int i = 0; i < numberOfStudents; i++)
                {
                    Console.Write($"Enter marks for student {i + 1}: ");
                    marks[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("\nEnter student index to view marks: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Marks of student at index {index}: {marks[index]}");

                Console.WriteLine("\nCalculating average marks...");
                int total = 0;
                foreach (int m in marks)
                {
                    total += m;
                }

                int average = total / marks.Length; // throws DivideByZeroException if marks.Length == 0
                Console.WriteLine($"Average Marks: {average}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter numeric values only.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: The student index you entered is invalid.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot calculate average because there are no students.");
            }
            finally
            {
                Console.WriteLine("Result processing completed.");
            }
        }
    }
}

