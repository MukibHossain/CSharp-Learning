//✅ Compile - Time Polymorphism(Method Overloading)
//1.Create a class Calculator with multiple overloaded versions of a method Calculate().
//Implement the following overloads:
//One that takes two integers and returns their sum.
//One that takes two doubles and returns their product.
//One that takes three integers and returns their average.
//Write a program that demonstrates compile-time polymorphism
//by calling each version of the Calculate() method.

using System;
class Calculator
{
    public int Calculate(int a, int b)
    {
        return a + b;
    }

    public double Calculate(double a, double b)
    {
        return a * b;
    }


    public double Calculate(int a, int b, int c)
    {
        return (a + b + c) / 3.0;
    }
}
class Program
{
    static void Main()
    {
        Calculator cal = new Calculator();

        Console.WriteLine("Sum of 10 and 20 = " + cal.Calculate(10, 20));

        Console.WriteLine("Product of 2.5 and 4.0 = " + cal.Calculate(2.5, 4.0));

        Console.WriteLine("Average of 10, 20 and 30 = " + cal.Calculate(10, 20, 30));
    }
}
