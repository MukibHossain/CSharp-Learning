//Create a class Student with a string field Name, an int field Age, and a string field Grade. Define a
//parameterized constructor that accepts values for Name, Age, and Grade, and assigns them to the
//corresponding fields. Write a program that creates an instance of the Student class by passing
//arguments to the constructor and displays the student's details.

using System;
class Student
{
    public string Name;
    public int Age;
    public string Grade;
    // Parameterized constructor
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}
class Program
{
    static void Main()
    {
        Student student = new Student("Alice Johnson", 16, "10th Grade");
        Console.WriteLine("Student Details:");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("Grade: " + student.Grade);
    }
}
