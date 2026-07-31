//Student and Department
//Question
//Create two classes:
//Department
//Student
//A Student has a Department (Aggregation).
//Display the student's name and department information.

using System;
class Department
{
    public string DeptName;
    public string Faculty;

    public Department(string deptName, string faculty)
    {
        DeptName = deptName;
        Faculty = faculty;
    }
}
class Student
{
    public string Name;
    public Department Dept;
    public Student(string name, Department dept)
    {
        Name = name;
        Dept = dept;
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Department: " + Dept.DeptName);
        Console.WriteLine("Faculty: " + Dept.Faculty);
    }
}
class Program
{
    static void Main()
    {
        Department d = new Department("CSE", "Engineering");

        Student s = new Student("Hasan", d);

        s.Display();
    }
}