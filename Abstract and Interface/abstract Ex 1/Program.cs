//Create an abstract class `Shape` with an abstract method `CalculateArea()` and
//a non-abstract method `Display()` that prints "Calculating area...".Then create two 
//derived classes, `Circle` and `Rectangle`, that implement the `CalculateArea()` 
//method. The `Circle` class should calculate the area of a circle, and the `Rectangle` 
//class should calculate the area of a rectangle. Demonstrate the use of the abstract class
//by creating objects of `Circle` and `Rectangle` and calling their methods.

using System;
abstract class Shape
{
    public abstract double CalculateArea();

    public void Display()
    {
        Console.WriteLine("Calculating area...");
    }
}
class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    double width, height;

    public Rectangle (double w, double h)
    {
        width = w;
        height = h;
    }

    public override double CalculateArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        Shape c = new Circle(5.0);
        Shape r = new Rectangle(4.0, 5.8);

        c.Display();
        Console.WriteLine("Circle Area = " + c.CalculateArea());

        r.Display();
        Console.WriteLine("Rectangle Area = " + r.CalculateArea());
    }
}