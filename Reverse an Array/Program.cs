//Write a C# program that takes an array of integers as input, reverses the order of elements in the array,
//and prints the reversed array.

using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Original Array: " + string.Join(", ", numbers));
        Array.Reverse(numbers);
        Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));
    }
}

