/* A ride-sharing company wants to calculate fares for different vehicle types.

Requirements:
1. Create abstract class Vehicle with VehicleID, DriverName, BaseFare, constructor,
DisplayInfo(), and abstract CalculateFare().
2. Create interface IPremiumService with:
double CalculatePremiumCharge();
3. Create:
* Car : Vehicle, IPremiumService (LuxuryCharge; Fare = BaseFare + LuxuryCharge)
* Bike : Vehicle (Distance; Fare = BaseFare + Distance*10)
* SUV : Vehicle, IPremiumService (LuxuryCharge, ExtraPassengerCharge; Fare = BaseFare
+ LuxuryCharge + ExtraPassengerCharge)
4. In Main(), store all objects in Vehicle[], display details and fare using runtime
polymorphism. For premium vehicles, also display the premium charge.
 */
using System;
abstract class Vehicle
{
    public int VehicleId { get; set; }
    public string DriverName { get; set; }
    public double BaseFare { get; set; }

    public Vehicle(int id, string name, double basefare)
    {
        VehicleId = id;
        DriverName = name;
        BaseFare = basefare;
    }

    public void Display()
    {
        Console.WriteLine("Vehicle Id: " + VehicleId);
        Console.WriteLine("Driver Name: " + DriverName);
        Console.WriteLine("Base Fare: " + BaseFare);
    }

    public abstract double CalculateFare();
}
interface IPremiumService
{
    double CalculatePremiumCharge();
}

class Car : Vehicle, IPremiumService
{
    public double LuxuryCharge { get; set; }

    public Car(int id, string name, double basefare, double luxuryCharge)
        : base(id, name, basefare)
    {
        LuxuryCharge = luxuryCharge;
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
class Bike : Vehicle
{
    public double Distance { get; set; }

    public Bike(int id, string name, double basefare, double distance)
        : base(id, name, basefare)
    {
        Distance = distance;
    }

    public override double CalculateFare()
    {
        return BaseFare + Distance * 10;
    }
}
class SUV : Vehicle, IPremiumService
{
    public double LuxuryCharge { get; set; }
    public double ExtraPassengerCharge { get; set; }

    public SUV(int id, string name, double basefare, double luxuryCharge, double extraPassengerCharge)
        : base(id, name, basefare)
    {
        LuxuryCharge = luxuryCharge;
        ExtraPassengerCharge = extraPassengerCharge;
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
