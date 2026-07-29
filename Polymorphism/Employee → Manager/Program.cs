//✅ Run-Time Polymorphism (Method Overriding)
//3.Create two classes: Employee and Manager.
//The Employee class should have a virtual method
//Work() that prints "Employee is working."
//The Manager class should override the Work() 
//method to print "Manager is managing the team."
//Write a program that demonstrates run-time polymorphism
//by creating a base class reference(Employee) and 
//pointing it to a derived class object(Manager).
//Call the Work() method using the base class reference.

using System;
class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}
class Manager : Employee
{

    public override void Work()
    {
        Console.WriteLine("Manager is managing the team.");
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Manager();

        emp.Work();
    }
}
