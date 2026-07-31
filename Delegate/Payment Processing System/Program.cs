//Problem 1: Payment Processing System
//Question
//The system should support:
//Credit Card
//Debit Card
//Bkash
//The user enters:
//Amount
//Payment Method
//The delegate should call the selected payment method.

using System;

// Step 1: Create Delegate
delegate void PaymentDelegate(double amount);

class Payment
{
    public static void CreditCard(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card.");
    }

    public static void DebitCard(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Debit Card.");
    }

    public static void Bkash(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Bkash.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Debit Card");
        Console.WriteLine("3. Bkash");

        Console.Write("Choose Payment Method: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        PaymentDelegate pay = null;

        if (choice == 1)
        {
            pay = Payment.CreditCard;
        }
        else if (choice == 2)
        {
            pay = Payment.DebitCard;
        }
        else if (choice == 3)
        {
            pay = Payment.Bkash;
        }
        else
        {
            Console.WriteLine("Invalid Choice");
            return;
        }

        pay(amount);
    }
}