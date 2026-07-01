//Create a class Car with a string field Brand, a string field Model, and an int field Year. Define a default
//constructor that initializes these fields with default values: "Unknown" for Brand, "Unknown" for Model,
//and 0 for Year.Write a program that creates an instance of the Car class using the default constructor
//and displays the values of the fields.

using System;
class Car
{
    public string Brand;
    public string Model;
    public int Year;
    // Default constructor
    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        Year = 0;
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car();
        Console.WriteLine("Car Details:");
        Console.WriteLine("Brand: " + car.Brand);
        Console.WriteLine("Model: " + car.Model);
        Console.WriteLine("Year: " + car.Year);
    }
}

