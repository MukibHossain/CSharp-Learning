//An e-commerce system is being developed to calculate product
//quantities and prices for customer orders.
//Create a class OrderCalculator with multiple overloaded versions of the method Calculate(). 
//One version should take two integers representing the quantities of two products
//and return their total quantity, another should take two double values representing 
//the prices of two products and return their total price, and another should take a 
//List<int> containing the quantities of multiple products and return the total quantity. 
//Write a C# program to demonstrate compile-time polymorphism through method overloading by
//calling each version of the Calculate() method.
using System;
using System.Collections.Generic;

class OrderCalculator
{
    // Calculate total quantity of two products
    public int Calculate(int quantity1, int quantity2)
    {
        return quantity1 + quantity2;
    }

    // Calculate total price of two products
    public double Calculate(double price1, double price2)
    {
        return price1 + price2;
    }

    // Calculate total quantity of multiple products
    public int Calculate(List<int> quantities)
    {
        int total = 0;

        foreach (int quantity in quantities)
        {
            total += quantity;
        }

        return total;
    }
}

class Program
{
    static void Main()
    {
        OrderCalculator calculator = new OrderCalculator();

        // Calls Calculate(int, int)
        int totalQuantity = calculator.Calculate(5, 10);
        Console.WriteLine("Total Quantity: " + totalQuantity);

        // Calls Calculate(double, double)
        double totalPrice = calculator.Calculate(120.50, 250.75);
        Console.WriteLine("Total Price: " + totalPrice);

        // Calls Calculate(List<int>)
        List<int> quantities = new List<int> { 5, 10, 15, 20 };

        int multipleQuantity = calculator.Calculate(quantities);
        Console.WriteLine("Total Quantity of Multiple Products: " + multipleQuantity);
    }
}