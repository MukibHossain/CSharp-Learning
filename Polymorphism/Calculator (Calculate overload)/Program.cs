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

        Console.Write("Enter two integers (SUM): ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum = " + cal.Calculate(a, b));

        Console.Write("Enter two double (Multiply): ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Multiplication = " + cal.Calculate(x, y));


        Console.Write("Enter three integers (Average): ");
        int p = Convert.ToInt32(Console.ReadLine());
        int q = Convert.ToInt32(Console.ReadLine());
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Average = " + cal.Calculate(p, q, r));

    }
}
