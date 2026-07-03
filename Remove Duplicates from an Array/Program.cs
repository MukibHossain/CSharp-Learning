//Write a C# program that removes all duplicates from a given array of integers and prints the resulting
//array.

using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] numbers = { 4, 8, 4, 6, 8, 2, 9, 6, 1 };
        Console.WriteLine("Original Array: " + string.Join(", ", numbers));
        int[] uniqueNumbers = numbers.Distinct().ToArray();
        Console.WriteLine("Array Without Duplicates: " + string.Join(", ", uniqueNumbers));
    }
}
