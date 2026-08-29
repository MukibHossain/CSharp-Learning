//Question 3: Ride Sharing Management System (Abstract Class + Interface + Runtime Polymorphism)
//Scenario: A ride-sharing company wants to calculate fares for different vehicle types. 
//Requirements: 1.Create abstract class Vehicle with VehicleID, DriverName, BaseFare, 
//constructor, DisplayInfo(), and abstract CalculateFare(). 2.Create interface IPremiumService
//with: double CalculatePremiumCharge(); 3.Create: • Car: Vehicle, IPremiumService(LuxuryCharge;
//Fare = BaseFare + LuxuryCharge) • Bike: Vehicle(Distance; Fare = BaseFare + Distance * 10) • SUV:
//Vehicle, IPremiumService(LuxuryCharge, ExtraPassengerCharge; Fare = BaseFare + LuxuryCharge +
//ExtraPassengerCharge) 4.In Main(), store all objects in Vehicle[], display details and fare 
//using runtime polymorphism. For premium vehicles, also display the premium charge. 

using System;

// Abstract Class
abstract class Vehicle
{
    public int VehicleID { get; set; }
    public string DriverName { get; set; }
    public double BaseFare { get; set; }

    public Vehicle(int id, string name, double fare)
    {
        VehicleID = id;
        DriverName = name;
        BaseFare = fare;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Vehicle ID: " + VehicleID);
        Console.WriteLine("Driver Name: " + DriverName);
        Console.WriteLine("Base Fare: " + BaseFare);
    }

    public abstract double CalculateFare();
}

// Interface
interface IPremiumService
{
    double CalculatePremiumCharge();
}

// Car
class Car : Vehicle, IPremiumService
{
    public double LuxuryCharge { get; set; }

    public Car(int id, string name, double fare, double luxury)
        : base(id, name, fare)
    {
        LuxuryCharge = luxury;
    }

    public override double CalculateFare()
    {
        return BaseFare + LuxuryCharge;
    }

    public double CalculatePremiumCharge()
    {
        return LuxuryCharge;
    }
}

// Bike
class Bike : Vehicle
{
    public double Distance { get; set; }

    public Bike(int id, string name, double fare, double distance)
        : base(id, name, fare)
    {
        Distance = distance;
    }

    public override double CalculateFare()
    {
        return BaseFare + Distance * 10;
    }
}

// SUV
class SUV : Vehicle, IPremiumService
{
    public double LuxuryCharge { get; set; }
    public double ExtraPassengerCharge { get; set; }

    public SUV(int id, string name, double fare, double luxury, double extra)
        : base(id, name, fare)
    {
        LuxuryCharge = luxury;
        ExtraPassengerCharge = extra;
    }

    public override double CalculateFare()
    {
        return BaseFare + LuxuryCharge + ExtraPassengerCharge;
    }

    public double CalculatePremiumCharge()
    {
        return LuxuryCharge + ExtraPassengerCharge;
    }
}


// Main Class
class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(1, "Hasan", 100, 50);
        vehicles[1] = new Bike(2, "Rahim", 80, 5);
        vehicles[2] = new SUV(3, "Karim", 150, 70, 30);

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();

            Console.WriteLine("Total Fare: " + v.CalculateFare());

            if (v is IPremiumService premium)
            {
                Console.WriteLine("Premium Charge: " + premium.CalculatePremiumCharge());
            }

            Console.WriteLine();
        }
    }
}

// Main Class
class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(1, "Hasan", 100, 50);
        vehicles[1] = new Bike(2, "Rahim", 80, 5);
        vehicles[2] = new SUV(3, "Karim", 150, 70, 30);

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();

            Console.WriteLine("Total Fare: " + v.CalculateFare());

            if (v is IPremiumService premium)
            {
                Console.WriteLine("Premium Charge: " + premium.CalculatePremiumCharge());
            }

            Console.WriteLine();
        }
    }
}