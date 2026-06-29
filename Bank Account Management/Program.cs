//4.Write a C# program for a bank account.

//Requirements:
//Create a method Deposit() that increases the account balance.
//Create a method Withdraw() that decreases the balance (only if enough money exists).
//Create a method CheckBalance() that displays the current balance.
//Use these methods from the Main() function.

using System;

class BankAccount
{
    private int balance = 0;

    public void Deposit(int amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(int amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Not enough balance");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1500);
        account.Withdraw(300);
        account.CheckBalance();
    }
}
