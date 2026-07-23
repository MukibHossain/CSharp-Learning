using System;

interface IEmployee
{
    void AssignEmail();
    void AssignManager();
}

class PermanentEmployee : IEmployee
{
    public void AssignEmail()
    {
        Console.WriteLine("Permanent Employee Email Assigned.");
    }

    public void AssignManager()
    {
        Console.WriteLine("Permanent Employee Manager Assigned.");
    }
}

class ContractualEmployee : IEmployee
{
    public void AssignEmail()
    {
        Console.WriteLine("Contractual Employee Email Assigned.");
    }

    public void AssignManager()
    {
        Console.WriteLine("Contractual Employee Manager Assigned.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Interface Reference
        IEmployee permanent = new PermanentEmployee();
        IEmployee contractual = new ContractualEmployee();

        Console.WriteLine("Permanent Employee:");
        permanent.AssignEmail();
        permanent.AssignManager();

        Console.WriteLine();

        Console.WriteLine("Contractual Employee:");
        contractual.AssignEmail();
        contractual.AssignManager();

        Console.ReadKey();
    }
}