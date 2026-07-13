//2.Write a C# program to create a vehicle class hierarchy. The base class should be

//Vehicle, with subclasses Truck, Car and Motorcycle. Each subclass should have

//properties such as model, year, and fuel type. Implement methods for calculating

//fuel efficiency, distance travelled, and maximum speed.


using System;

class Vehicle
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string FuelType { get; set; }
}

class Car : Vehicle
{
    public void FuelEfficiency()
    {
        Console.WriteLine("20 km/l");
    }
    public void DistanceTravelled()
    {
        Console.WriteLine("50 km");
    }
    public void MaximumSpeed()
    {
        Console.WriteLine("200 km/h");
    }
}

class Truck : Vehicle
{
    public void FuelEfficiency() { Console.WriteLine("10 km/l"); }
    public void DistanceTravelled() { Console.WriteLine("350 km"); }
    public void MaximumSpeed() { Console.WriteLine("100 km/h"); }
}

class Motorcycle : Vehicle
{
    public void FuelEfficiency() { Console.WriteLine("60 km/l"); }
    public void DistanceTravelled() { Console.WriteLine("400 km"); }
    public void MaximumSpeed() { Console.WriteLine("120 km/h"); }
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Model = "Toyota";
        c.Year = 2022;
        c.FuelType = "Petrol";

        Console.WriteLine(c.Model);
        Console.WriteLine(c.Year);
        Console.WriteLine(c.FuelType);
        c.FuelEfficiency();
        c.DistanceTravelled();
        c.MaximumSpeed();

        Motorcycle m = new Motorcycle();
        m.Model = "Yamaha";
        m.Year = 2021;
        m.FuelType = "Petrol";
        Console.WriteLine(m.Model);
        Console.WriteLine(m.Year);
        Console.WriteLine(m.FuelType);
        m.FuelEfficiency();
        m.DistanceTravelled();
        m.MaximumSpeed();
    }
}

