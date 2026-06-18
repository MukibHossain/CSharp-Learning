using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter last number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest = num1;

        //Compare with other numbers

        if(num2 > largest)
        {
            largest = num2;
        }

        if(num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine("The largest number is: " + largest);
    }
}
