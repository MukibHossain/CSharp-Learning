using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: "); 
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter array elements: ");

        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Step 1: Sort the array (simple trick to make it easy)
        Array.Sort(arr);

        int largest = arr[size - 1]; // Last element is the largest 
        int secondlargest = -1;

        // Step 2: Find second largest (different from largest)

        for(int i = size-2; i >= 0; i--)
        {
            if (arr[i] != largest)
            {
                secondlargest = arr[i];
                break;
            }
        }

        // Step 3: Output result

        if (secondlargest == -1)
        {
            Console.WriteLine("Second largest number not found");
        }
        else
        {
            Console.WriteLine("Second largest number is: " + secondlargest);
        }


    }
}

