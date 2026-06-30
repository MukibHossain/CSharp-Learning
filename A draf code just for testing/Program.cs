// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Student
{
    int studentId;
    string name;
    double cgpa;
    public int StudentId { get; set; }
    public string Name { get; set; }
    public double CGPA
    {
        get
        {
            return cgpa;
        }
        set
        {
            if (value > 0.0 && value <= 4.0)
            {
                cgpa = value;
            }
            else
            {
                cgpa = 0.0;
            }
        }
    }
    public Student(int sId, string n, double cg)
    {
        StudentId = sId;
        Name = n;
        CGPA = cg;

    }
}
class StudentList
{
    private Student[] students = new Student[2];

    public Student this[int index]
    {
        get { return students[index]; }
        set { students[index] = value; }
    }
}
class Program
{
    static void Main()
    {
        StudentList list = new StudentList();

        list[0] = new Student(23, "X", 4.0);
        list[1] = new Student(24, "Y", 5.0);

        Console.WriteLine(list[0].StudentId + " " +
                          list[0].Name + " " +
                          list[0].CGPA);
    }
}
