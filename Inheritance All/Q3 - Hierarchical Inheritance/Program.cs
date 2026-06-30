//Create a base class Vehicle with a property Speed and a method ShowSpeed(). Then create
//two derived classes, Car and Bike, which inherit from Vehicle. Both Car and Bike should have
//their own method ShowType() that prints whether the vehicle is a car or a bike. Demonstrate
//hierarchical inheritance by creating objects of both Car and Bike.

using System;

class Vehicle
{
    // Property
    public int Speed;

    // Method
    public void ShowSpeed()
    {
        Console.WriteLine("Speed: " + Speed + " km/h");
    }
}

// Car class inherits from Vehicle
class Car : Vehicle
{
    public void ShowType()
    {
        Console.WriteLine("This is a Car");
    }
}

// Bike class inherits from Vehicle
class Bike : Vehicle
{
    public void ShowType()
    {
        Console.WriteLine("This is a Bike");
    }
}

class Program
{
    static void Main()
    {
        // Creating Car object
        Car c = new Car();
        c.Speed = 120;

        c.ShowType();
        c.ShowSpeed();

        Console.WriteLine();

        // Creating Bike object
        Bike b = new Bike();
        b.Speed = 80;

        b.ShowType();
        b.ShowSpeed();
    }
}