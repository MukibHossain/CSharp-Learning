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
        Console.WriteLine("Car starting");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopping");
    }
}
class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike starting");
    }

    public void Stop()
    {
        Console.WriteLine("Bike stopping");
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car();
        Bike bike = new Bike();

        car.Start();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.Stop();
    }
}