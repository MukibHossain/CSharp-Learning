//A company is developing an employee management system. 
//Different employees may perform tasks using the same method 
//name but with different parameters. The system also has 
//different types of employees where a specific employee can provide its own implementation of a common method.
//Write a C# program for the employee management system that 
//demonstrates both forms of polymorphism using method overloading
//and method overriding. Explain in comments which version of each method executes and why.

using System;

// =====================================================
// PART 1: Compile-Time Polymorphism - Method Overloading
// =====================================================
public class Employee
{
    public string Name = "Employee";

    // Same method name "AssignTask", different parameters
    public void AssignTask(string task)
    {
        Console.WriteLine(Name + " is assigned: " + task);
    }

    public void AssignTask(string task, int days)
    {
        Console.WriteLine(Name + " is assigned: " + task + " (deadline: " + days + " days)");
    }

    // =====================================================
    // PART 2: Run-Time Polymorphism - Method Overriding
    // =====================================================
    // "virtual" allows derived classes to override this method
    public virtual void Work()
    {
        Console.WriteLine(Name + " is doing general employee work");
    }
}

public class Manager : Employee
{
    // Overriding the base class method
    public override void Work()
    {
        Console.WriteLine("Manager is managing the team");
    }
}

public class Developer : Employee
{
    // Overriding the base class method
    public override void Work()
    {
        Console.WriteLine("Developer is writing code");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Method Overloading (Compile-Time) ----");

        Employee emp = new Employee();
        emp.AssignTask("Prepare report");
        // Calls AssignTask(string) -> matched by ONE argument (a string)
        // Decided by the compiler at COMPILE TIME.

        emp.AssignTask("Prepare report", 3);
        // Calls AssignTask(string, int) -> matched by TWO arguments
        // Also a compile-time decision.

        Console.WriteLine();
        Console.WriteLine("---- Method Overriding (Run-Time) ----");

        Employee e1 = new Employee();
        Employee e2 = new Manager();   // base class reference, derived object
        Employee e3 = new Developer(); // base class reference, derived object

        e1.Work(); // Runs Employee.Work() -> actual object is Employee
        e2.Work(); // Runs Manager.Work()  -> actual object is Manager
        e3.Work(); // Runs Developer.Work()-> actual object is Developer
        // Even though e1, e2, e3 are all declared as type "Employee",
        // the RUNTIME checks the ACTUAL object type to decide which
        // Work() method to call. This is decided while the program runs.
    }
}