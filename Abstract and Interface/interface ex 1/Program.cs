//Define an interface `IVehicle` with two methods: `Start()` and `Stop()`. Create 
//two classes, `Car` and `Bike`, that implement the `IVehicle` interface. The `Car` class
//should implement `Start()` to print "Car starting..." and `Stop()` to print "Car 
//stopping...". The `Bike` class should implement `Start()` to print "Bike starting..." and 
//`Stop()` to print "Bike stopping...". Write a program that demonstrates interface
//implementation by creating instances of both `Car` and `Bike` and calling their 
//methods.
using System;
interface IVehicle
{
    void Start();
    void Stop();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car Starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Car Stopping...");
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike Starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Bike Stopping...");
    }
}

class Program
{
    static void Main()
    {
        IVehicle car = new Car();
        IVehicle bike = new Bike();

        car.Start();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.Stop();
    }
}
