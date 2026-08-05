//Question 1: Employee Payroll System (Abstract Class + Runtime Polymorphism)
//Scenario:
//A software company wants to automate its monthly payroll system. All employees have
//common information such as Employee ID, Name, and Basic Salary, but different employee
//types receive different allowances.
//Requirements:
//1.Create an abstract class Employee with properties EmployeeID, Name, BasicSalary; a
//constructor; DisplayInfo(); and abstract CalculateSalary().
//2.Create Manager(HRA = 30 %, Medical = 20 %) and SoftwareEngineer(HRA= 20 %,
//Performance Bonus = 15 %) classes.
//3.Override CalculateSalary().
//4.In Main(), store one Manager and one SoftwareEngineer in an Employee[] array and use
//runtime polymorphism to display information and calculated salary.

using System;
public abstract class  Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public double BasicSalary { get; set; }

    public Employee(int employeeID, string name, double basicSalary)
    {
        EmployeeID = employeeID;
        Name = name;
        BasicSalary = basicSalary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Salary: " + BasicSalary);
    }

    public abstract double CalculateSalary();
}

class Manager : Employee
{
    public Manager (int id, string name, double salary) : base(id, name, salary)
    {

    }
    public override double CalculateSalary()
    {
        double hra = .3 * BasicSalary;
        double medical = .2 * BasicSalary;

        return BasicSalary + hra + medical;
    }
}

class SoftwareEngineer : Employee
{
    public SoftwareEngineer (int id, string name, double salary) : base(id, name, salary)
    {

    }

    public override double CalculateSalary()
    {
        double hra = .2 * BasicSalary;
        double performanceBonus = .15 * BasicSalary;

        return BasicSalary + hra + performanceBonus;
    }
}

class Program
{
    static void Main()
    {
        Employee[] emp = new Employee[2];

        emp[0] = new Manager(01, "Mukib", 60000);
        emp[1] = new SoftwareEngineer(02, "Emon", 45000);

        foreach (Employee e in emp)
        {
            e.DisplayInfo();
            Console.WriteLine("Total Salary: " + e.CalculateSalary());
            Console.WriteLine();

        }
    }
}