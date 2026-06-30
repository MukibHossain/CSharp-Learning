//Create two classes: Person and Student.The Person class should have the properties Name
//and Age, and a method DisplayInfo() that prints the name and age. The Student class should
//inherit from Person and have an additional property StudentID and method
//DisplayStudentInfo() that prints the student ID along with the name and age. Demonstrate
//single inheritance by creating a Student object.

using System;

class Person
{
    // Properties
    public string Name;
    public int Age;

    // Method to display person info
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    // Additional property
    public int StudentID;

    // Method to display student info
    public void DisplayStudentInfo()
    {
        DisplayInfo(); // inherited method
        Console.WriteLine("Student ID: " + StudentID);
    }
}

class Program
{
    static void Main()
    {
        // Creating Student object
        Student s = new Student();

        // Assigning values
        s.Name = "Rahim";
        s.Age = 20;
        s.StudentID = 101;

        // Displaying information
        s.DisplayStudentInfo();
    }
}