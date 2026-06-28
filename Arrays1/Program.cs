//Question 1: Arrays
//Write a C# program that:
//• Takes 10 integer values as input and stores them in an array.
//• Finds the largest and smallest numbers.
//• Calculates the average of all elements.
//• Displays all results.

using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10]; //size of the array
        Console.Write("Enter teh elements of the array: ");

        for(int i = 0; i<10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int largest = arr[0];
        int smallest = arr[0];
        int sum = 0;

        foreach(int n in arr)
        {
            if(n>largest)
            {
                largest = n;
            }
            else
            {
                smallest = n;
            }
            sum += n;
        }

        double average = sum / arr.Length;
        Console.WriteLine("Largest Number: " + largest);
        Console.WriteLine("Smallest Number: " + smallest);
        Console.WriteLine("Average: " + average);

    }
}

