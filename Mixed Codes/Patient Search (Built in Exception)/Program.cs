//Create a C# program for a hospital that stores patient records in a Dictionary<int, string>,
//where the key is the Patient ID and the value is the patient's name.
//Requirements:
//Accept a Patient ID from the user.
//Display the patient's name if the ID exists.
//Handle:
//FormatException — when the user enters a non-numeric Patient ID.
//KeyNotFoundException — when the Patient ID does not exist in the dictionary.

using System;
using System.Collections.Generic;
class PatientSearch
{
    static void Main()
    {
        Dictionary<int, string> patients = new Dictionary<int, string>();

        patients.Add(101, "Hasan");
        patients.Add(102, "Rahim");
        patients.Add(103, "Karim");

        try
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            string name = patients[id];

            Console.WriteLine("Patient Name: " + name);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid Patient ID.");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine("Patient record not found.");
        }
    }
}