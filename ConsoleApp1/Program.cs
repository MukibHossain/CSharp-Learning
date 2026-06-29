//Question 4: Scenario - Based Question(Exam Standard)
//A college wants to store information about its students.
//Write a C# program that:
//● Creates a class named Student with the following data members:
//o StudentID
//o Name
//o Department
//o CGPA
//● Uses a parameterized constructor to initialize the student information.
//● Implements a method named ShowStudentInfo() to display all details.
//● Creates five Student objects and displays their information.

using System;
class student
{
    public int Studentid;
    public string Name;
    public string department;
    public double CGPA;


    // parameterized constructor to initialize the student information
    public student(int id, string name, string dept, double cgpa)
        {
       
                Studentid = id;
                Name = name;
                department = dept;
                CGPA = cgpa;

        }

     //show or display the info

     public void showstudnetinfo()

        {
            Console.WriteLine("Student ID: " + Studentid);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA: " + CGPA);
        }
}

class Program
{
    static void Main()
    {
        // five stduent objects

        student s1 = new student(1, "John Doe", "Computer Science", 3.5);
        student s2 = new student(2, "John Do", "Computer Science", 3.5);
        student s3 = new student(3, "John D", "Computer Science", 3.5);
        student s4 = new student(4, "John ", "Computer Science", 3.5);
        student s5 = new student(5, "Joh", "Computer Science", 3.5);

        s1.showstudnetinfo();
        s2.showstudnetinfo();
        s3.showstudnetinfo();
        s4.showstudnetinfo();
        s5.showstudnetinfo();

    }
}

