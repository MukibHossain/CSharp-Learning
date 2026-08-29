//Vehicle Rental Management System
//This program models Car, Bike, and Truck vehicle types inheriting from a base Vehicle class. Each derived class overrides CalculateRentalCost(int days) with its own cost formula. The base class also defines overloaded rental - cost methods that add a discount and/or an additional charge.
//Design Summary
//Vehicle (base class): VehicleId, Model, BaseRate, virtual CalculateRentalCost(int days) + 2 overloaded variants (with discount, and with discount + additional charge).
//Car: overrides CalculateRentalCost() → BaseRate × days + InsuranceCharge.
//Bike: overrides CalculateRentalCost() → BaseRate × days.
//Truck: overrides CalculateRentalCost() → BaseRate × days + LoadCharge.
//A List<Vehicle> holds all vehicle objects; calling CalculateRentalCost() through the base reference resolves to the correct derived-class implementation at runtime.
//C# Code
using System;
using System.Collections.Generic;
 
namespace VehicleRentalManagementSystem
{
    // Base class
    class Vehicle
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public double BaseRate { get; set; }

        public Vehicle(int vehicleId, string model, double baseRate)
        {
            VehicleId = vehicleId;
            Model = model;
            BaseRate = baseRate;
        }

        // Virtual method - default implementation
        public virtual double CalculateRentalCost(int days)
        {
            return BaseRate * days;
        }

        // Overloaded methods
        public virtual double CalculateRentalCost(int days, double discount)
        {
            double cost = CalculateRentalCost(days);
            return cost - discount;
        }

        public virtual double CalculateRentalCost(int days, double discount, double additionalCharge)
        {
            double cost = CalculateRentalCost(days, discount);
            return cost + additionalCharge;
        }
    }

    class Car : Vehicle
    {
        public double InsuranceCharge { get; set; }

        public Car(int vehicleId, string model, double baseRate, double insuranceCharge)
            : base(vehicleId, model, baseRate)
        {
            InsuranceCharge = insuranceCharge;
        }

        // Car: Base rate x days + insurance charge
        public override double CalculateRentalCost(int days)
        {
            return (BaseRate * days) + InsuranceCharge;
        }
    }

    class Bike : Vehicle
    {
        public Bike(int vehicleId, string model, double baseRate)
            : base(vehicleId, model, baseRate) { }

        // Bike: Base rate x days
        public override double CalculateRentalCost(int days)
        {
            return BaseRate * days;
        }
    }

    class Truck : Vehicle
    {
        public double LoadCharge { get; set; }

        public Truck(int vehicleId, string model, double baseRate, double loadCharge)
            : base(vehicleId, model, baseRate)
        {
            LoadCharge = loadCharge;
        }

        // Truck: Base rate x days + additional load charge
        public override double CalculateRentalCost(int days)
        {
            return (BaseRate * days) + LoadCharge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car(1, "Toyota Corolla", 50, 20),
                new Bike(2, "Yamaha FZ", 15),
                new Truck(3, "Volvo FH", 100, 40)
            };

            int rentalDays = 5;

            Console.WriteLine("---- Rental Cost Report (Runtime Polymorphism) ----");
            foreach (Vehicle v in vehicles)
            {
                // Overridden method invoked through base-class reference
                double cost = v.CalculateRentalCost(rentalDays);
                Console.WriteLine($"VehicleId: {v.VehicleId}, Model: {v.Model}, Type: {v.GetType().Name}, Rental Cost ({rentalDays} days): {cost}");
            }

            Console.WriteLine("\n---- Demonstrating Method Overloading ----");
            Car car = new Car(4, "Honda Civic", 55, 25);
            Console.WriteLine($"Car cost (days only): {car.CalculateRentalCost(4)}");
            Console.WriteLine($"Car cost (days + discount): {car.CalculateRentalCost(4, 30)}");
            Console.WriteLine($"Car cost (days + discount + extra charge): {car.CalculateRentalCost(4, 30, 15)}");
        }
    }
}

