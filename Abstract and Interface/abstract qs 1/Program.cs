using System;
//creating asbtract class
public abstract class EmployeeDress
{
    public abstract void DressCode();

    public void DressColor()
    {
        Console.WriteLine("Dress Color: BLUE");
    }
}
class PermanentEmployee : EmployeeDress
{
    public override void DressCode()
    {
        Console.WriteLine("Formal Office Wear");
    }
}
class ContractualEmployee : EmployeeDress
{
    public override void DressCode()
    {
        Console.WriteLine("Smart Casual");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeDress emp1 = new PermanentEmployee();
        emp1.DressCode();
        emp1.DressColor();
        EmployeeDress emp2 = new ContractualEmployee();
        emp2.DressCode();
        emp2.DressColor();
    }
}