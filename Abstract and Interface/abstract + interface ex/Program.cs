//Create an abstract class `Appliance` with an abstract method `TurnOn()` and a 
//non-abstract method `TurnOff()` that prints "Turning off the appliance".Define an 
//interface `IControllable` with a method `Control()`. Create a class `WashingMachine` 
//that inherits from `Appliance` and implements the `IControllable` interface. 
//Implement the `TurnOn()` method to print "Washing machine turning on..." and 
//`Control()` to print "Controlling washing machine...". Demonstrate the use of both the 
//abstract class and the interface by creating an object of `WashingMachine` and calling 
//all the methods.

using System;

abstract class Appliance
{
    public abstract void TurnOn();

    public void TurnOff()
    {
        Console.WriteLine("Turning off the appliance");
    }
}

interface IControllable
{
    void Control();
}

class WashingMachine : Appliance, IControllable
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing Machine Turning On...");
    }

    public void Control()
    {
        Console.WriteLine("Controlling Washing Machine...");
    }
}

class Program
{
    static void Main()
    {
        WashingMachine wm = new WashingMachine();

        wm.TurnOn();
        wm.Control();
        wm.TurnOff();
    }
}
