//Hospital Billing System (Abstract Class + Interface + Polymorphism) 
//Scenario 
//A hospital wants to automate its patient billing system. Every patient shares common information,
//but the billing process differs depending on the type of patient. Additionally, only insured patients 
//can claim insurance. 
//Requirements 
//1. Create an abstract class 'Patient'
//Properties: -PatientID - Name - Age - ConsultationFee
//Methods: -Constructor - DisplayInfo() - Abstract method CalculateBill()
//2.Create the following derived classes 
//IndoorPatient - Additional: NumberOfDays, RoomChargePerDay - Bill = ConsultationFee + (NumberOfDays × RoomChargePerDay) - Implements IInsurance 
//OutdoorPatient - Additional: TestCharge - Bill = ConsultationFee + TestCharge - Does NOT implement IInsurance 
//EmergencyPatient - Additional: EmergencyCharge - Bill = ConsultationFee + EmergencyCharge - Implements IInsurance
//3. Create an interface 'IInsurance'
//Method: -double ClaimAmount();
//Insurance Claim = 80 % of Total Bill 
//4. In the Main() method - Store all patient objects in a Patient[] array. - Display patient information and total bill using runtime polymorphism. -Show insurance claim only for patients implementing IInsurance. 
using System;

// Abstract Class
abstract class Patient
{
    public int PatientID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double ConsultationFee { get; set; }

    public Patient(int id, string name, int age, double fee)
    {
        PatientID = id;
        Name = name;
        Age = age;
        ConsultationFee = fee;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Patient ID: " + PatientID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Consultation Fee: " + ConsultationFee);
    }

    public abstract double CalculateBill();
}

// Interface
interface IInsurance
{
    double ClaimAmount();
}

// Indoor Patient
class IndoorPatient : Patient, IInsurance
{
    public int NumberOfDays { get; set; }
    public double RoomChargePerDay { get; set; }

    public IndoorPatient(int id, string name, int age, double fee,
                         int days, double roomCharge)
        : base(id, name, age, fee)
    {
        NumberOfDays = days;
        RoomChargePerDay = roomCharge;
    }

    public override double CalculateBill()
    {
        return ConsultationFee + (NumberOfDays * RoomChargePerDay);
    }

    public double ClaimAmount()
    {
        return CalculateBill() * 0.80;
    }
}

