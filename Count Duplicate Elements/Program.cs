using System;
class Program {

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
        int duplicateCount = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicateCount++;
                    break;
                }
            }
        }
        Console.WriteLine("Number of duplicate elements: " + duplicateCount);
    }
}

