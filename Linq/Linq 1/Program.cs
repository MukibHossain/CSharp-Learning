//.Hospital Patient Management System - LINQ Join & Group By
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace HospitalPatientManagement
{
    class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public int DoctorID { get; set; }
    }

    class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Specialization { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>
            {
                new Patient { PatientID = 1, PatientName = "John",  DoctorID = 101 },
                new Patient { PatientID = 2, PatientName = "Sara",  DoctorID = 102 },
                new Patient { PatientID = 3, PatientName = "Mike",  DoctorID = 101 },
                new Patient { PatientID = 4, PatientName = "Lisa",  DoctorID = 103 },
                new Patient { PatientID = 5, PatientName = "Tom",   DoctorID = 102 }
            };

            List<Doctor> doctors = new List<Doctor>
            {
                new Doctor { DoctorID = 101, DoctorName = "Dr. Adams",   Specialization = "Cardiology" },
                new Doctor { DoctorID = 102, DoctorName = "Dr. Bennett", Specialization = "Neurology" },
                new Doctor { DoctorID = 103, DoctorName = "Dr. Clark",   Specialization = "Cardiology" }
            };

            // (a) Join Patients with Doctors
            var patientDoctorInfo =
                from p in patients
                join d in doctors on p.DoctorID equals d.DoctorID
                select new
                {
                    p.PatientName,
                    d.DoctorName,
                    d.Specialization
                };

            Console.WriteLine("---- (a) Patient - Doctor - Specialization ----");
            foreach (var item in patientDoctorInfo)
            {
                Console.WriteLine($"Patient: {item.PatientName}, Doctor: {item.DoctorName}, Specialization: {item.Specialization}");
            }

            // (b) Group patients by doctor specialization
            var groupedBySpecialization =
                from p in patients
                join d in doctors on p.DoctorID equals d.DoctorID
                group p by d.Specialization into g
                select new
                {
                    Specialization = g.Key,
                    PatientCount = g.Count()
                };

            Console.WriteLine("\n---- (b) Patient Count by Specialization ----");
            foreach (var item in groupedBySpecialization)
            {
                Console.WriteLine($"Specialization: {item.Specialization}, Number of Patients: {item.PatientCount}");
            }
        }
    }
}

