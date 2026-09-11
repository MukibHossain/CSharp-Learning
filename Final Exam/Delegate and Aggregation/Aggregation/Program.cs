//Create two classes, Hospital and Doctor.
//The Doctor class should have properties: Id, Name, and Specialization. 
//The Hospital class should have a List < Doctor > property representing 
//the doctors working at the hospital. Write a method in the Hospital 
//class that displays all doctors.Create doctor objects independently and add them to the hospital.
using System;
using System.Collections.Generic;
class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Doctor(int id, string name, string specialization)
    {
        Id = id;
        Name = name;
        Specialization = specialization;
    }
}

class Hospital
{
    public List<Doctor> Doctors { get; set; }

    public Hospital()
    {
        Doctors = new List<Doctor>();
    }

    public void DisplayDoctors()
    {
        foreach (Doctor doctor in Doctors)
        {
            Console.WriteLine("ID: " + doctor.Id);
            Console.WriteLine("Name: " + doctor.Name);
            Console.WriteLine("Specialization: " + doctor.Specialization);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Doctor objects are created independently
        Doctor d1 = new Doctor(1, "Dr. Rahman", "Cardiology");
        Doctor d2 = new Doctor(2, "Dr. Karim", "Neurology");
        Doctor d3 = new Doctor(3, "Dr. Hasan", "Dermatology");

        Hospital hospital = new Hospital();

        // Adding independently created doctors to the hospital
        hospital.Doctors.Add(d1);
        hospital.Doctors.Add(d2);
        hospital.Doctors.Add(d3);

        hospital.DisplayDoctors();
    }
}