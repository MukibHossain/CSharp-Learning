//Question 3: Properties and Indexers
//Create a Student class with private fields StudentID, Name and CGPA.
//Use properties to access all fields.
//Validate CGPA so it remains between 0.00 and 4.00 (otherwise set it to 0.00).
//Create a StudentList class that stores five Student objects in an array and implements an
//indexer to access students by index.
//Display all student information using the indexer.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    
}

