using System;

class Matrix
{
    static void Main()
    {
        int[,] num = new int[3, 3];
        int max;

        Console.WriteLine("Enter 9 numbers:");

        // Input
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                num[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        max = num[0, 0];

        // Row Sum and Maximum
        for (int i = 0; i < 3; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < 3; j++)
            {
                rowSum += num[i, j];

                if (num[i, j] > max)
                    max = num[i, j];
            }

            Console.WriteLine("Row " + (i + 1) + " Sum = " + rowSum);
        }

        // Column Sum
        for (int j = 0; j < 3; j++)
        {
            int colSum = 0;

            for (int i = 0; i < 3; i++)
            {
                colSum += num[i, j];
            }

            Console.WriteLine("Column " + (j + 1) + " Sum = " + colSum);
        }

        Console.WriteLine("Maximum = " + max);
    }
}
