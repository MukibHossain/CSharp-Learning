//Create a class Rectangle with a double field Length and a double field Width. Define three
//constructors:
//• A default constructor that sets Length and Width to 1.0.
//• A parameterized constructor that accepts both Length and Width.
//• A single-parameter constructor for creating a square, which reuses the two-parameter constructor
//via constructor chaining (this(...)).
//• Add a method Area() that returns Length * Width. Write a program that creates one object with
//each constructor and displays their areas.

using System;
class Rectangle
{
    public double Length;
    public double Width;
    // Default constructor
    public Rectangle() : this(1.0, 1.0)
    {
    }
    // Parameterized constructor
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    // Single-parameter constructor (square), chained to the 2-parameter one
    public Rectangle(double side) : this(side, side)
    {
    }
    public double Area()
    {
        return Length * Width;
    }
}
class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle(); // default: 1 x 1
        Rectangle r2 = new Rectangle(5.0, 3.0); // rectangle: 5 x 3
        Rectangle r3 = new Rectangle(4.0); // square: 4 x 4
        Console.WriteLine("r1 Area (default): " + r1.Area());
        Console.WriteLine("r2 Area (5 x 3): " + r2.Area());
        Console.WriteLine("r3 Area (square 4): " + r3.Area());
    }
}