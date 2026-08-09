//using System;

//Create a C# program for an online shopping system that accepts product price and quantity, then calculates and displays the total bill.

//The program must handle the following exceptions:

//FormatException — when the user enters non-numeric input.
//OverflowException — when the entered number is outside the range of the data type.
//ArgumentOutOfRangeException — when price or quantity is less than or equal to 0. This exception must be thrown manually.
using System;
class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }
    public double TotalAmount { get; set; }

    public void Display()
    {
        Console.WriteLine("\nPrice : " + Price);
        Console.WriteLine("Quantity : " + Quantity);
        Console.WriteLine("Total Amount : " + TotalAmount);
    }
}

