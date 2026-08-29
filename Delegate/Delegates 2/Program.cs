//Write a delegate CalculateCircleArea that takes a double parameter (radius) and returns a
//double (the area of the circle). Write a method GetArea that calculates the area of a circle
//using the formula π * radius ^ 2.Create an instance of the delegate and use it to calculate and
//print the area for a circle with a radius of 7.
//Code: 
using System;

class Program
{
    delegate double CalculateCircleArea(double radius);

    static double GetArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        CalculateCircleArea calculate = GetArea;

        double radius = 7;

        double area = calculate(radius);

        Console.WriteLine("Area = " + area);
    }
}

