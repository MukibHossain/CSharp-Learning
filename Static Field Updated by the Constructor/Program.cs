//Create a class BankAccount with a string field Owner, a double field Balance, and a static int field
//TotalAccounts shared by every instance. Define a parameterized constructor that sets Owner and
//Balance and increments TotalAccounts by 1 each time a new account is created.Write a program that
//creates three BankAccount objects and displays each one's details plus the total number of accounts
//created.
using System;
class BankAccount
{
    public string Owner;
    public double Balance;
    public static int TotalAccounts;
    // Parameterized constructor
    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
        TotalAccounts++;
    }
    public void Display()
    {
        Console.WriteLine("Owner: " + Owner + ", Balance: $" + Balance);
    }
}
class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("John Smith", 1500.00);
        BankAccount acc2 = new BankAccount("Priya Nair", 2300.50);
        BankAccount acc3 = new BankAccount("Diego Ramirez", 800.75);
        acc1.Display();
        acc2.Display();
        acc3.Display();
        Console.WriteLine("Total Accounts Created: " + BankAccount.TotalAccounts);
    }
}
