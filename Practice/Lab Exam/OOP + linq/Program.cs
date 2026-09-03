using System;
using System.Collections.Generic;
using System.Linq;

class Manager
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int Salary { get; set; }

    public Manager(string name, int id, int salary)
    {
        Name = name;
        ID = id;
        Salary = salary;
    }
}
class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int id, int salary)
    {
        Name = name;
        ID = id;
        Salary = salary;
    }
}
class Branch
{
    public string Name { get; set; }
    public string Location { get; set; }
    public Manager Manager { get; set; }
    public List<Employee> Employees { get; set; }

    public Branch(string name, string location, Manager manager,
                  List<Employee> employees)
    {
        Name = name;
        Location = location;
        Manager = manager;
        Employees = employees;
    }
}

class Company
{
    public string Name { get; set; }
    public string Headquarters { get; set; }
    public List<Branch> Branches { get; set; }

    public Company(string name, string headquarters,
                   List<Branch> branches)
    {
        Name = name;
        Headquarters = headquarters;
        Branches = branches;
    }
    public void PrintBranchesWithHighPaidManager()
    {
        var result = Branches
            .Where(b => b.Manager.Salary > 50000)
            .Select(b => b.Name);
        foreach (string branchName in result)
        {
            Console.WriteLine(branchName);
        }
    }
}