//A company is developing an employee management system. 
//Different employees may perform tasks using the same method 
//name but with different parameters. The system also has 
//different types of employees where a specific employee can provide its own implementation of a common method.
//Write a C# program for the employee management system that 
//demonstrates both forms of polymorphism using method overloading
//and method overriding. 


using System;
public class Employee
{
    public string Name; 

    public void AssignTask(string task)
    {
        Console.WriteLine(Name + " is assigned: " + task);
    }

    public void AssignTask(string task, int days)
    {
        Console.WriteLine(Name + " is assigned: " + task + " (deadline: " + days + " days)");
    }

    public virtual void Work()
    {
        Console.WriteLine(Name + " is doing general employee work");
    }
}

public class Manager : Employee
{

    public override void Work()
    {
        Console.WriteLine(Name + " (Manager) is managing the team");
    }
}
public class Developer : Employee
{

    public override void Work()
    {
        Console.WriteLine(Name + " (Developer) is writing code");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Employee emp = new Employee();

        Console.Write("Enter employee name: ");
        emp.Name = Console.ReadLine();

        emp.AssignTask("Prepare report");

        emp.AssignTask("Prepare report", 3);



        Console.Write("Enter manager name: ");
        Manager mgr = new Manager();
        mgr.Name = Console.ReadLine(); 

        Console.Write("Enter developer name: ");
        Developer dev = new Developer();
        dev.Name = Console.ReadLine(); 

        Employee e1 = emp; // Employee reference to an Employee object
        Employee e2 = mgr; // Employee reference to a Manager object
        Employee e3 = dev; // Employee reference to a Developer object

        e1.Work(); // Runs Employee.Work()  -> actual object is Employee
        e2.Work(); // Runs Manager.Work()   -> actual object is Manager
        e3.Work(); // Runs Developer.Work() -> actual object is Developer
    }
}