//Employee and Company
//Question
//Create two classes:
//Company
//Employee
//An Employee has a Company (Aggregation).
//Display the employee and company details.

using System;
class Company
{
    public string CompanyName;
    public string Location;

    public Company(string companyName, string location)
    {
        CompanyName = companyName;
        Location = location;
    }
}

class Employee
{
    public string Name;
    public Company Comp;

    public Employee(string name, Company comp)
    {
        Name = name;
        Comp = comp;
    }

    public void Display()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Company: " + Comp.CompanyName);
        Console.WriteLine("Location: " + Comp.Location);
    }
}

class Program
{
    static void Main()
    {
        Company c = new Company("Microsoft", "Dhaka");

        Employee e = new Employee("Rahim", c);

        e.Display();
    }
}
