using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        int searchValue = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] == searchValue)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Element found in the array.");

        }
        else
        {
            Console.WriteLine("Element not found in the array.");
        }
    }
}