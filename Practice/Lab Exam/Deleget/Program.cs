//An online shopping system provides different discount rates for different types of customers.
//Create a C# program using delegates based on the following requirements:
//Create a class Customer with properties: Id, Name, and PurchaseAmount.
//Create methods to calculate discounts:
//RegularDiscount() → 5 % discount
//PremiumDiscount() → 10 % discount
//VIPDiscount() → 20 % discount
//Declare a delegate named DiscountCalculator that can reference these discount methods.
//Based on the customer's membership type, assign the appropriate method to the delegate.
//Use the delegate to calculate and display the customer's discount amount and final payable amount.

using System;
class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double PurchaseAmount { get; set; }

    public double RegularDiscount()
    {
        return PurchaseAmount * 0.05;
    }
    public double PremiumDiscount()
    {
        return PurchaseAmount * 0.10;
    }
    public double VIPDiscount()
    {
        return PurchaseAmount * 0.20;
    }
}
class Program
{
    delegate double DiscountCalculator();
    static void Main()
    {
        Customer c = new Customer();

        c.Id = 1;
        c.Name = "Rahim";
        c.PurchaseAmount = 10000;

        DiscountCalculator d;

        string type = "VIP";

        if (type == "Regular")
            d = c.RegularDiscount;
        else if (type == "Premium")
            d = c.PremiumDiscount;
        else
            d = c.VIPDiscount;

        double discount = d();

        double finalAmount = c.PurchaseAmount - discount;

        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Amount: " + finalAmount);
    }
}

