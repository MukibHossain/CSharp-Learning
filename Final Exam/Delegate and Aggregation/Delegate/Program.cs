//An online shopping system provides different discount rates for different types of customers.
//Create a C# program using delegates based on the following requirements:
//Create a class Customer with properties: Id, Name, and Purchase Amount
//Create methods to calculate discounts:
//RegularDiscount()→ 5 % discount
//Premium Discount()→ 10 % discount
//VIPDiscount()→ 20 % discount
//Declare a delegate named DiscountCalculator that can reference these discount methods.
//Based on the customer's membership type, assign the appropriate method to the delegate.
//Use the delegate to calculate and display the customer's discount amount and final payable amount
using System;

public delegate double DiscountCalculator(double amount);
class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double PurchaseAmount { get; set; }

    public double RegularDiscount(double amount)
    {
        return amount * 0.05;
    }

    public double PremiumDiscount(double amount)
    {
        return amount * 0.10;
    }

    public double VIPDiscount(double amount)
    {
        return amount * 0.20;
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer
        {
            Id = 101,
            Name = "Rahim",
            PurchaseAmount = 10000
        };

        string membershipType = "VIP";

        DiscountCalculator discount;

        if (membershipType == "Regular")
        {
            discount = customer.RegularDiscount;
        }
        else if (membershipType == "Premium")
        {
            discount = customer.PremiumDiscount;
        }
        else
        {
            discount = customer.VIPDiscount;
        }

        double discountAmount = discount(customer.PurchaseAmount);
        double finalAmount = customer.PurchaseAmount - discountAmount;

        Console.WriteLine("Customer ID: " + customer.Id);
        Console.WriteLine("Customer Name: " + customer.Name);
        Console.WriteLine("Membership Type: " + membershipType);
        Console.WriteLine("Purchase Amount: " + customer.PurchaseAmount);
        Console.WriteLine("Discount Amount: " + discountAmount);
        Console.WriteLine("Final Payable Amount: " + finalAmount);
    }
}