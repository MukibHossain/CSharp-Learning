using System;

// =====================================================
// PART 1: Compile-Time Polymorphism - Method Overloading
// =====================================================
public class Employee
{
    public string Name; // no default value now - will be set from user input

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
        Console.WriteLine(Name + " (Manager) is managing the team");
    }
}

public class Developer : Employee
{
    // Overriding the base class method
    public override void Work()
    {
        Console.WriteLine(Name + " (Developer) is writing code");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Method Overloading (Compile-Time) ----");

        Employee emp = new Employee();

        Console.Write("Enter employee name: ");
        emp.Name = Console.ReadLine(); // <-- USER INPUT sets the Name

        emp.AssignTask("Prepare report");
        // Calls AssignTask(string) -> matched by ONE argument (a string)

        emp.AssignTask("Prepare report", 3);
        // Calls AssignTask(string, int) -> matched by TWO arguments

        Console.WriteLine();
        Console.WriteLine("---- Method Overriding (Run-Time) ----");

        Console.Write("Enter manager name: ");
        Manager mgr = new Manager();
        mgr.Name = Console.ReadLine(); // <-- USER INPUT sets the Name

        Console.Write("Enter developer name: ");
        Developer dev = new Developer();
        dev.Name = Console.ReadLine(); // <-- USER INPUT sets the Name

        Employee e1 = emp; // Employee reference to an Employee object
        Employee e2 = mgr; // Employee reference to a Manager object
        Employee e3 = dev; // Employee reference to a Developer object

        e1.Work(); // Runs Employee.Work()  -> actual object is Employee
        e2.Work(); // Runs Manager.Work()   -> actual object is Manager
        e3.Work(); // Runs Developer.Work() -> actual object is Developer
        // Even though e1, e2, e3 are all declared as type "Employee",
        // the RUNTIME checks the ACTUAL object type to decide which
        // Work() method to call.
    }
}