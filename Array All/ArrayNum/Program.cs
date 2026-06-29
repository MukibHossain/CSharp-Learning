//Question 1: Write a C# program that:
//• Takes 10 integer values as input and stores them in an array.
//• Finds the largest and smallest numbers.
//• Calculates the average of all elements.
//• Displays all results.
using System;
class ArrayNum
{
    static void Main()
    {
        int[] num = new int[10];
        int max, min, sum = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        max = min = num[0];

        for (int i = 0; i < 10; i++)
        {
            if (num[i] > max)
                max = num[i];

            if (num[i] < min)
                min = num[i];

            sum += num[i];
        }

        double avg = (double)sum / 10;

        Console.WriteLine("Largest = " + max);
        Console.WriteLine("Smallest = " + min);
        Console.WriteLine("Average = " + avg);
    }
}
