//Write a C# program to handle IndexOutOfRangeException.

using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 10, 20, 30 };

            Console.Write("Enter array index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value = " + numbers[index]);
        }
