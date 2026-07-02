//Create a class Employee with a string field Name, an int field Id, and a double field Salary. Define a
//default constructor that sets Name to "Not Assigned", Id to 0, and Salary to 0.0, and a separate
//parameterized constructor that accepts values for all three fields (use the this. keyword to distinguish
//fields from parameters). Write a program that creates one Employee with each constructor and displays
//both.

using System;
class Employee
{
    public string Name;
    public int Id;
    public double Salary;
    // Default constructor
    public Employee()
    {
        Name = "Not Assigned";
        Id = 0;
        Salary = 0.0;
    }
    // Parameterized constructor
    public Employee(string name, int id, double salary)
    {
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }
    public void Display()
    {
        Console.WriteLine("Name: " + Name + ", Id: " + Id + ", Salary: $" + Salary);
    }
}
class Program
{
    static void Main()
    {
        Employee temp = new Employee();
        Employee hired = new Employee("Maria Lopez", 1024, 62000.0);
        Console.WriteLine("Unassigned Employee:");
        temp.Display();
        Console.WriteLine("\nHired Employee:");
        hired.Display();
    }
}
