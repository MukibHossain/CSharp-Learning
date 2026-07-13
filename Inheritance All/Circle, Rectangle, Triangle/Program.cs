//Write a C# program where the bases class is shape. And the derived classes are of

//different shape. (Circle, Rectangle, Triangle etc.) The member method of the the

//derived classes are going to calculate the area of the shape.

//For example,

//Circle class will calculate the area of the circle, rectangle class or triangle will also

//do the same.





using System;

class Shape
{
    public string Name { get; set; }

    public void ShowName()
    {
        Console.WriteLine("Shape: " + Name);
    }
}

class Circle : Shape
{
    public void Area()
    {
        double r = 5;
        Console.WriteLine("Area of Circle = " + (3.1416 * r * r));
    }
}


class Rectangle : Shape
{
    public void Area()
    {
        double l = 10;
        double w = 5;
        Console.WriteLine("Area of Rectangle = " + (l * w));
    }
}

class Triangle : Shape
{
    public void Area()
    {
        double b = 8;
        double h = 6;
        Console.WriteLine("Area of Triangle = " + (0.5 * b * h));
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle();
        c.Name = "Circle";
        c.ShowName();
        c.Area();

        Rectangle r = new Rectangle();
        r.Name = "Rectangle";
        r.ShowName();
        r.Area();

        Triangle t = new Triangle();
        t.Name = "Triangle";
        t.ShowName();
        t.Area();

    }
}

