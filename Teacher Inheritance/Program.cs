//Question 5: Inheritance
//Create a base class Person with Name and Age.
//Create a derived class Teacher with EmployeeID and Subject.
//Use properties for all members.
//Implement a Display() method in Teacher.
//In Main(), create a Teacher object, assign values, and display the details.


using System;

// Base Class
class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

// Derived Class
class Teacher : Person
{
    private int employeeID;
    private string subject;

    public int EmployeeID
    {
        get { return employeeID; }
        set { employeeID = value; }
    }

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Subject: " + Subject);
    }
}

class Program
{
    static void Main()
    {
        Teacher t = new Teacher();

        t.Name = "Mukib";
        t.Age = 24;
        t.EmployeeID = 101;
        t.Subject = "Computer Science";

        t.Display();
    }
}