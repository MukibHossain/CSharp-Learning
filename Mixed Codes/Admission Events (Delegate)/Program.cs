//Problem 2: University Admission System using Events
//Problem Statement:
//When a student's admission is completed, the system should automatically: 
//• Generate Student ID 
//• Send Welcome Email 
//• Create LMS Account 
//• Create Library Account 
//Requirements: 
//● Create a delegate named AdmissionHandler. 
//● Create a publisher class named AdmissionOffice.
//● Declare an event named AdmissionCompleted. 
//● Implement subscriber methods: 
//• GenerateStudentID()
//• SendWelcomeEmail()
//• CreateLMSAccount()
//• CreateLibraryAccount()
//● Raise the event after admission is completed. 

using System;

delegate void AdmissionHandler();

class AdmissionOffice
{
   
    public event AdmissionHandler AdmissionCompleted;

    public void CompleteAdmission()
    {
        Console.WriteLine("Admission Completed.");

       
        AdmissionCompleted();
    }
}



class University
{
    public void GenerateStudentID()
    {
        Console.WriteLine("Student ID Generated.");
    }

    public void SendWelcomeEmail()
    {
        Console.WriteLine("Welcome Email Sent.");
    }

    public void CreateLMSAccount()
    {
        Console.WriteLine("LMS Account Created.");
    }

    public void CreateLibraryAccount()
    {
        Console.WriteLine("Library Account Created.");
    }
}


class Program
{
    static void Main()
    {
        AdmissionOffice office = new AdmissionOffice();
        University university = new University();
      
        office.AdmissionCompleted += university.GenerateStudentID;
        office.AdmissionCompleted += university.SendWelcomeEmail;
        office.AdmissionCompleted += university.CreateLMSAccount;
        office.AdmissionCompleted += university.CreateLibraryAccount;

        office.CompleteAdmission();
    }
}