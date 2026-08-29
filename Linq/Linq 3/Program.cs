using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { ID = 1, Name = "Alice",   Department = "IT",      Gender = "Female", Salary = 75000 },
                new Employee { ID = 2, Name = "Bob",     Department = "IT",      Gender = "Male",   Salary = 55000 },
                new Employee { ID = 3, Name = "Charlie", Department = "HR",      Gender = "Male",   Salary = 62000 },
                new Employee { ID = 4, Name = "Diana",   Department = "IT",      Gender = "Female", Salary = 90000 },
                new Employee { ID = 5, Name = "Ethan",   Department = "Finance", Gender = "Male",   Salary = 70000 }
            };

            var itHighEarners = employees
                .Where(e => e.Department == "IT" && e.Salary > 60000)
                .Select(e => new { e.Name, e.Salary });

            Console.WriteLine("---- IT Employees with Salary > 60,000 ----");
            foreach (var emp in itHighEarners)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}

