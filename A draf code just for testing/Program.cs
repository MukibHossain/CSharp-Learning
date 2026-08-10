using System;

class InBal : Exception
{
    public InBal(string message) : base(message)
    {
    }
}

class ATM
{
    public double Balance { get; set; }

    public void Display()
    {
        Console.WriteLine("Remaining Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        ATM a = new ATM();
        a.Balance = 15000;

        try
        {
            Console.Write("Enter withdraw amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "amount",
                    "The amount must be greater than 0."
                );
            }

            if (amount > a.Balance)
            {
                throw new InBal(
                    "Insufficient balance for this transaction."
                );
            }

            a.Balance = a.Balance - amount;

            Console.WriteLine("Withdrawal Successful");
            a.Display();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InBal ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}