//✅ Run - Time Polymorphism(Method Overriding)
//4.Create two classes: Vehicle and Car.
//The Vehicle class should have a virtual method StartEngine() 
//that prints "Vehicle engine started."
//The Car class should override the StartEngine() method to print
//"Car engine started with keyless ignition."
//Write a program that demonstrates run-time polymorphism by
//creating a base class reference(Vehicle) and assigning it 
//to a derived class object(Car).Call the StartEngine() method 
//using the base class reference.
using System;
class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine started.");
    }
}
class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with keyless ignition.");
    }
}
class Program
{
    static void Main()
    {
        Vehicle vehicle = new Car();
        vehicle.StartEngine();
    }
}
