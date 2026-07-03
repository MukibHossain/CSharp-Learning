//Create Shape(Draw()), Polygon inherits from Shape and adds ShowSides(), and Rectangle inherits
//from Polygon and adds CalculateArea(width, height). Demonstrate multilevel inheritance by creating a
//Rectangle object and calling all methods.

using System;
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}
class Polygon : Shape
{
    public int Sides;
    public Polygon(int sides)
    {
        Sides = sides;
    }
    public void ShowSides()
    {
        Console.WriteLine("Number of sides: " + Sides);
    }
}
class Rectangle : Polygon
{
    public Rectangle() : base(4)
    {
    }
    public void CalculateArea(double width, double height)
    {
        double area = width * height;
        Console.WriteLine("Area: " + area);
    }
}
class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.Draw();
        rect.ShowSides();
        rect.CalculateArea(6.0, 4.0);
 