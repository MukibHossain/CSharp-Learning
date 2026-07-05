using System;

abstract class Shape
{
    public Shape()
    {
        Console.WriteLine("Shape Constructor");
    }

    public abstract void Draw();
}

class Circle : Shape
{
    public Circle()
    {
        Console.WriteLine("Circle Constructor");
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
    }
}