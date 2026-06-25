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

