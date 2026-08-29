

//C# OOP Practice Solutions
//Inheritance, Polymorphism, Method Overloading & Exception Handling
//Contents:
//1.Employee Payroll Management System
//2. Vehicle Rental Management System
//3. E-Commerce Order System (Custom Exceptions)
//4. University Student Marks System (Exception Handling)

//1. Employee Payroll Management System
//This program models three employee types (Full-Time, Part-Time, Contract) that inherit from a common Employee base class. Each derived class overrides CalculateSalary() to apply its own salary formula, and the base class also defines overloaded versions of CalculateSalary() that accept extra parameters (bonus / hourly rate & hours / contract amount & deduction).
//Design Summary
//Employee (base class): Id, Name, BasicSalary, virtual CalculateSalary() + 3 overloaded variants.
//FullTimeEmployee: overrides CalculateSalary() → BasicSalary + Bonus.
//PartTimeEmployee: overrides CalculateSalary() → HourlyRate × HoursWorked.
//ContractEmployee: overrides CalculateSalary() → ContractAmount − Deduction.
//A List<Employee> holds all employee objects; CalculateSalary() is invoked via the base-class reference, demonstrating runtime polymorphism.
//C# Code
using System;
using System.Collections.Generic;
 
namespace PayrollManagementSystem
{
    // Base class
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }

        public Employee(int id, string name, double basicSalary)
        {
            Id = id;
            Name = name;
            BasicSalary = basicSalary;
        }

        // Virtual method - default implementation
        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }

        // Overloaded versions (base provides default logic)
        public virtual double CalculateSalary(double bonus)
        {
            return BasicSalary + bonus;
        }

        public virtual double CalculateSalary(double hourlyRate, int hours)
        {
            return hourlyRate * hours;
        }

        public virtual double CalculateSalary(double contractAmount, double deduction)
        {
            return contractAmount - deduction;
        }
    }

    class FullTimeEmployee : Employee
    {
        public double Bonus { get; set; }

        public FullTimeEmployee(int id, string name, double basicSalary, double bonus)
            : base(id, name, basicSalary)
        {
            Bonus = bonus;
        }

        // Full-time: Basic salary + bonus
        public override double CalculateSalary()
        {
            return BasicSalary + Bonus;
        }
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(int id, string name, double basicSalary, double hourlyRate, int hoursWorked)
            : base(id, name, basicSalary)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        // Part-time: Hourly rate x working hours
        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    class ContractEmployee : Employee
    {
        public double ContractAmount { get; set; }
        public double Deduction { get; set; }

        public ContractEmployee(int id, string name, double basicSalary, double contractAmount, double deduction)
            : base(id, name, basicSalary)
        {
            ContractAmount = contractAmount;
            Deduction = deduction;
        }

        // Contract: Contract amount - deduction
        public override double CalculateSalary()
        {
            return ContractAmount - Deduction;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(1, "Alice", 30000, 5000),
                new PartTimeEmployee(2, "Bob", 0, 500, 80),
                new ContractEmployee(3, "Charlie", 0, 60000, 4000)
            };

            Console.WriteLine("---- Employee Salary Report ----");
            foreach (Employee emp in employees)
            {
                // Overridden method called through the base-class reference
                double salary = emp.CalculateSalary();
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Type: {emp.GetType().Name}, Final Salary: {salary}");
            }

            Console.WriteLine("\n---- Demonstrating Overloaded CalculateSalary Methods ----");
            FullTimeEmployee ft = new FullTimeEmployee(4, "Dana", 25000, 0);
            Console.WriteLine($"FullTime overload (bonus): {ft.CalculateSalary(3000)}");

            PartTimeEmployee pt = new PartTimeEmployee(5, "Evan", 0, 0, 0);
            Console.WriteLine($"PartTime overload (rate, hours): {pt.CalculateSalary(600, 90)}");

            ContractEmployee ce = new ContractEmployee(6, "Fay", 0, 0, 0);
            Console.WriteLine($"Contract overload (amount, deduction): {ce.CalculateSalary(70000, 5000)}");
        }
    }
}

