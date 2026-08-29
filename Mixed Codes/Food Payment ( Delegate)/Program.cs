//Problem 1: Food Delivery Payment System using Delegates
//Problem Statement:
//Develop an Online Food Delivery System where customers can pay using Cash on Delivery, bKash, or Credit Card. 
//Requirements: 
//● Define a delegate named PaymentDelegate. 
//● Create methods: 
//• CashOnDelivery(double amount)
//• BkashPayment(double amount)
//• CreditCardPayment(double amount)
//● Ask the user to enter the food bill. 
//● Ask the user to choose a payment method. 
//● Use the delegate to invoke the selected payment method. 
//● Display a payment confirmation and 'Order Confirmed Successfully.' 

using System;
delegate void PaymentDelegate(double amount);
class Payment
{
    public static void CashOnDelivery(double amount)
    {
        Console.WriteLine("Payment Method: Cash on Delivery");
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Payments will be collected upon delivery.");
    }
    public static void BkashPayment(double amount)
    {
        Console.WriteLine("Payment Method: Bkash");
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Payment will be processed through Bkash.");
    }
    public static void CreditCardPayment(double amount)
    {
        Console.WriteLine("Payment Method: Card");
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Payment will be processed through Card.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Food Bill: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n1. Cash on Delivery");
        Console.WriteLine("2. bKash");
        Console.WriteLine("3. Credit Card");

        Console.Write("Choose Payment Method: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        PaymentDelegate payment = null;

        if (choice == 1)
        {
            payment = Payment.CashOnDelivery;
        }
        else if (choice == 2)
        {
            payment = Payment.BkashPayment;
        }
        else if (choice == 3)
        {
            payment = Payment.CreditCardPayment;
        }
        else
        {
            Console.WriteLine("Invalid Choice.");
            return;
        }

        Console.WriteLine();

        payment(amount);

        Console.WriteLine("Order Confirmed Successfully.");
    }
}