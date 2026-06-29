//Question 5: Write a C# program that:
//• Creates two integer arrays of size 5 each.
//• Accepts values for both arrays from the user.
//• Creates a third array that stores the element-wise sum.
//• Displays all three arrays and the total sum of the third array
using System;

class AddArr
{
    static void Main()
    {
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[5];
        int total = 0;

        Console.WriteLine("Enter 5 numbers for first array:");
        for (int i = 0; i < 5; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter 5 numbers for second array:");
        for (int i = 0; i < 5; i++)
        {
            b[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            c[i] = a[i] + b[i];
            total += c[i];
        }
        //print of all array also the sum
        Console.Write("First Array: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.Write("\nSecond Array: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(b[i] + " ");
        }

        Console.Write("\nThird Array: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(c[i] + " ");
        }

        Console.WriteLine("\nTotal Sum = " + total);
    }
}