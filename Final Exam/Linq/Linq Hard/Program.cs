using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double CGPA { get; set; }
    public string City { get; set; }
}

class Result
{
    public int ResultId { get; set; }
    public int StudentId { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 101, Name = "Rahim", Department = "CSE", CGPA = 3.80, City = "Dhaka" },
            new Student { StudentId = 102, Name = "Karim", Department = "CSE", CGPA = 3.45, City = "Gazipur" },
            new Student { StudentId = 103, Name = "Nadia", Department = "EEE", CGPA = 3.90, City = "Dhaka" },
            new Student { StudentId = 104, Name = "Sakib", Department = "BBA", CGPA = 3.60, City = "Sylhet" },
            new Student { StudentId = 105, Name = "Tania", Department = "EEE", CGPA = 3.70, City = "Dhaka" }
        };

        List<Result> results = new List<Result>
        {
            new Result { ResultId = 1, StudentId = 101, Course = "Programming", Marks = 88, Grade = "A+" },
            new Result { ResultId = 2, StudentId = 102, Course = "Programming", Marks = 72, Grade = "A" },
            new Result { ResultId = 3, StudentId = 103, Course = "Electronics", Marks = 91, Grade = "A+" },
            new Result { ResultId = 4, StudentId = 104, Course = "Accounting", Marks = 78, Grade = "A" },
            new Result { ResultId = 5, StudentId = 105, Course = "Electronics", Marks = 84, Grade = "A+" }
        };


        // =========================
        // QUESTION 1 - JOIN
        // =========================

        var q1 = students.Join(
            results,
            s => s.StudentId,
            r => r.StudentId,
            (s, r) => new
            {
                s.Name,
                s.Department,
                r.Course,
                r.Marks,
                r.Grade
            });

        Console.WriteLine("QUESTION 1");
        foreach (var x in q1)
        {
            Console.WriteLine(
                x.Name + " | " +
                x.Department + " | " +
                x.Course + " | " +
                x.Marks + " | " +
                x.Grade);
        }


        // =========================
        // QUESTION 2 - FILTERING
        // =========================

        var q2 = students.Join(
            results,
            s => s.StudentId,
            r => r.StudentId,
            (s, r) => new { s.Name, s.CGPA, r.Course, r.Marks }
        )
        .Where(x => x.CGPA > 3.60 && x.Marks > 80);

        Console.WriteLine("\nQUESTION 2");
        foreach (var x in q2)
        {
            Console.WriteLine(
                x.Name + " | " +
                x.CGPA + " | " +
                x.Course + " | " +
                x.Marks);
        }


        // =========================
        // QUESTION 3 - SORTING
        // =========================

        var q3 = students.Join(
            results,
            s => s.StudentId,
            r => r.StudentId,
            (s, r) => new
            {
                s.Name,
                r.Course,
                r.Marks
            })
            .OrderByDescending(x => x.Marks);

        Console.WriteLine("\nQUESTION 3");
        foreach (var x in q3)
        {
            Console.WriteLine(
                x.Name + " | " +
                x.Course + " | " +
                x.Marks);
        }


        // =========================
        // QUESTION 4 - PROJECTION
        // =========================

        var q4 = students.Join(
            results,
            s => s.StudentId,
            r => r.StudentId,
            (s, r) => new
            {
                s.Name,
                s.Department,
                s.CGPA,
                r.Grade
            });

        Console.WriteLine("\nQUESTION 4");
        foreach (var x in q4)
        {
            Console.WriteLine(
                x.Name + " | " +
                x.Department + " | " +
                x.CGPA + " | " +
                x.Grade);
        }


        // =========================
        // QUESTION 5 - GROUPING
        // =========================

        var q5 = students
            .GroupBy(s => s.Department)
            .Select(g => new
            {
                Department = g.Key,
                NumberOfStudents = g.Count(),
                AverageCGPA = g.Average(s => s.CGPA)
            });

        Console.WriteLine("\nQUESTION 5");
        foreach (var x in q5)
        {
            Console.WriteLine(
                x.Department + " | " +
                x.NumberOfStudents + " | " +
                x.AverageCGPA);
        }


        // =========================
        // QUESTION 6 - HIGHEST PERFORMER
        // =========================

        var q6 = students.Join(
            results,
            s => s.StudentId,
            r => r.StudentId,
            (s, r) => new
            {
                s.Name,
                s.Department,
                r.Course,
                r.Marks
            })
            .OrderByDescending(x => x.Marks)
            .First();

        Console.WriteLine("\nQUESTION 6");
        Console.WriteLine(
            q6.Name + " | " +
            q6.Department + " | " +
            q6.Course + " | " +
            q6.Marks);


        // =========================
        // QUESTION 7 - AVERAGE MARKS
        // =========================

        double q7 = results.Average(r => r.Marks);

        Console.WriteLine("\nQUESTION 7");
        Console.WriteLine("Average Marks = " + q7);


        // =========================
        // QUESTION 8 - CONDITIONAL SEARCH
        // =========================

        var q8 = students
            .Where(s => s.City == "Dhaka" || s.CGPA > 3.70);

        Console.WriteLine("\nQUESTION 8");
        foreach (var x in q8)
        {
            Console.WriteLine(
                x.Name + " | " +
                x.Department + " | " +
                x.CGPA + " | " +
                x.City);
        }


        // =========================
        // QUESTION 9 - COUNT
        // =========================

        int q9 = results.Count(r => r.Grade == "A+");

        Console.WriteLine("\nQUESTION 9");
        Console.WriteLine("Count of A+ Students = " + q9);


        // =========================
        // QUESTION 10 - FINAL CHALLENGE
        // =========================

        var q10 = students.Join(
            results,
            s => s.StudentId,
            r => r.StudentId,
            (s, r) => new
            {
                s.Name,
                s.Department,
                s.CGPA,
                r.Course,
                r.Marks,
                r.Grade
            })
            .OrderByDescending(x => x.Marks)
            .ThenByDescending(x => x.CGPA)
            .First();

        Console.WriteLine("\nQUESTION 10");
        Console.WriteLine(
            q10.Name + " | " +
            q10.Department + " | " +
            q10.CGPA + " | " +
            q10.Course + " | " +
            q10.Marks + " | " +
            q10.Grade);
    }
}
