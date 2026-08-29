//3.Create two classes, Hospital and Doctor.
//The Doctor class should have properties: Id, Name, and Specialization.
//The Hospital class should have a List < Doctor > property representing the doctors working at the hospital.
//Write a method in the Hospital class that displays all doctors.
//Create doctor objects independently and add them to the hospital.
//Source Code:

using System;
using System.Collections.Generic;

class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
}

class Hospital
{
    public List<Doctor> Doctors { get; set; } = new List<Doctor>();

    public void DisplayDoctors()
    {
        foreach (Doctor d in Doctors)
        {
            Console.WriteLine("ID: " + d.Id);
            Console.WriteLine("Name: " + d.Name);
            Console.WriteLine("Specialization: " + d.Specialization);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Doctor d1 = new Doctor();
        d1.Id = 1;
        d1.Name = "Rahim";
        d1.Specialization = "Cardiology";

        Doctor d2 = new Doctor();
        d2.Id = 2;
        d2.Name = "Karim";
        d2.Specialization = "Neurology";

        Hospital h = new Hospital();

        h.Doctors.Add(d1);
        h.Doctors.Add(d2);

        h.DisplayDoctors();
    }
}
