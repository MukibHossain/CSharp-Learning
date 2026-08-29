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

class Program
{
    static void Main()
    {
        ATM atm = new ATM();

        atm.Balance = 15000;

        try
        {
            Console.Write("Enter Withdrawal Amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Withdrawal amount must be greater than 0.");
            }

            if (amount > atm.Balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient balance for this transaction.");
            }

            atm.Balance = atm.Balance - amount;

            Console.WriteLine("Withdrawal Successful.");
            atm.Display();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}