//Create a C# program for an ATM system where the customer has 15,000 Tk
//in their account and wants to withdraw money.
//Requirements:
//Accept the withdrawal amount.
//Deduct the amount if sufficient balance exists.
//Handle:
//FormatException — when the user enters an invalid withdrawal amount.
//ArgumentOutOfRangeException — when the withdrawal amount is less than or equal to 0. Throw manually.
//InsufficientBalanceException — when the withdrawal amount is greater than the available balance.
//Create and throw this custom exception manually.

using System;
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}
class ATM
{
    public double Balance { get; set; }

    public void Display()
    {
        Console.WriteLine("\nRemaining Balance : " + Balance);
    }
}
