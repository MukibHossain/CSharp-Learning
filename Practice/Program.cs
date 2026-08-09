using System;
abstract class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public abstract void CalculateBonus();

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee Name: " + Name);
    }
}

class Manager : Employee
{
    public Manager(string name) : base(name)
    {
    }

    public override void CalculateBonus()
    {
        Console.WriteLine("Manager bonus: 20% of salary");
    }
}

class Developer : Employee
{
    public Developer(string name) : base(name)
    {
    }

    public override void CalculateBonus()
    {
        Console.WriteLine("Developer bonus: 10% of salary");
    }
}
class Program
{
    static void Main()
    {
        Manager manager = new Manager("Emon Mahmud");
        Developer developer = new Developer("Mukib Hossain");

        manager.DisplayEmployee();
        manager.CalculateBonus();

        Console.WriteLine();

        developer.DisplayEmployee();
        developer.CalculateBonus();
    }
}
