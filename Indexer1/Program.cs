//Question 3: Properties and Indexers
//Create a Student class with private fields StudentID, Name and CGPA.
//Use properties to access all fields.
//Validate CGPA so it remains between 0.00 and 4.00 (otherwise set it to 0.00).
//Create a StudentList class that stores five Student objects in an array and implements an
//indexer to access students by index.
//Display all student information using the indexer.

using System;
class student
{
    //private fields
    private int studentID;
    private string name;
    private double cgpa;

    public int StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    //property for cgpa

    public double CGPA
    { 
        get {return cgpa; }
        set
        {
            if(value >= 0.00 && value <= 4.00)
            {
                cgpa = value;
            }
            else
            {
                cgpa = 0.00;
            }
        }
    }

    //studentlist class creation

    class StudentList
    {
        private student[] students = new student[5];

        //indexer to access students by index
        public student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
    }
    // class main
    class Program
    {
        static void Main()
        {
            StudentList list = new StudentList();

            // 5 students info

            list[0] = new student { StudentID = 101, Name = "Mukib", CGPA = 3.5 };
            list[1] = new student { StudentID = 102, Name = "Odhi", CGPA = 4.0 };
            list[2] = new student { StudentID = 103, Name = "OdhiJr", CGPA = 3.98 };
            list[3] = new student { StudentID = 104, Name = "MukibJr", CGPA = 3.99 };
            list[4] = new student { StudentID = 105, Name = "Odhini", CGPA = 3.89 };

            Console.WriteLine("Studnet Info\n");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student ID: {list[i].StudentID}, Name: {list[i].Name}, CGPA: {list[i].CGPA}");
            }
        }
    }

}

