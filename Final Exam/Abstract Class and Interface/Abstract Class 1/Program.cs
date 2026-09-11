//You are designing a vehicle rental system.
//The system has different types of vehicles — Car, Bike, and Truck.
//All vehicles share some common behavior, 
//such as calculating a RentalCost() based on shared base logic, 
//and they all should have a default StartEngine() method
//that prints a generic startup message. At the same time, 
//every vehicle in the system must guarantee that it can be 
//Inspect()ed for safety compliance before rental — a capability 
//that unrelated classes outside the vehicle hierarchy (e.g., 
//a RentalStation class) may also need to implement.
//Given this scenario, decide whether an abstract class or an
//interface is the more suitable design choice for modeling 
//RentalCost()/StartEngine() versus modeling the Inspect() 
//capability. Implement your choice in C#

using System;

// Interface: Inspect() capability - needed by unrelated classes too
public interface IInspectable
{
    void Inspect();
}

// Abstract class: shared vehicle behavior
public abstract class Vehicle : IInspectable
{
    // Concrete/default method - same for all vehicles unless overridden
    public virtual void StartEngine()
    {
        Console.WriteLine("Engine started (generic startup)");
    }

    // Abstract method - each vehicle type calculates its own cost
    public abstract double RentalCost();

    // Every vehicle must implement Inspect() via the interface
    public abstract void Inspect();
}

public class Car : Vehicle
{
    public override double RentalCost() => 50.0;

    public override void Inspect()
    {
        Console.WriteLine("Car inspected: tires, brakes, lights OK");
    }
}

public class Bike : Vehicle
{
    public override double RentalCost() => 15.0;

    public override void Inspect()
    {
        Console.WriteLine("Bike inspected: chain, brakes OK");
    }
}

public class Truck : Vehicle
{
    public override double RentalCost() => 100.0;

    public override void Inspect()
    {
        Console.WriteLine("Truck inspected: load capacity, brakes OK");
    }
}

// Unrelated class - not a Vehicle, but still needs Inspect()
public class RentalStation : IInspectable
{
    public void Inspect()
    {
        Console.WriteLine("Rental station facility inspected for safety compliance");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car();
        Vehicle bike = new Bike();
        Vehicle truck = new Truck();
        IInspectable station = new RentalStation();

        car.StartEngine();
        Console.WriteLine("Car rental cost: " + car.RentalCost());
        car.Inspect();

        Console.WriteLine();
        bike.StartEngine();
        Console.WriteLine("Bike rental cost: " + bike.RentalCost());
        bike.Inspect();

        Console.WriteLine();
        truck.StartEngine();
        Console.WriteLine("Truck rental cost: " + truck.RentalCost());
        truck.Inspect();

        Console.WriteLine();
        station.Inspect();  // Unrelated class, same contract via interface
    }
}