//Question 2: Write a C# program that:
//• Takes 7 float values as input and stores them in an array.
//• Sorts the array in ascending order using a loop (without built -in Sort).
//• Displays the sorted array and the median value.

using System;
class SortNum
{
    static void Main()
    {
        float[] num = new float[7];
        float temp;

        Console.WriteLine("Enter 7 numbers:");

        for (int i = 0; i < 7; i++)
        {
            num[i] = Convert.ToSingle(Console.ReadLine());
        }

        // Ascending Sort
        for (int i = 0; i < 6; i++)
        {
            for (int j = i + 1; j < 7; j++)
            {
                if (num[i] > num[j])
                {
                    temp = num[i];
                    num[i] = num[j];
                    num[j] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");

        for (int i = 0; i < 7; i++)
        {
            Console.Write(num[i] + " ");
        }

        Console.WriteLine("\nMedian = " + num[3]);
    }
}