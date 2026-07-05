using System;

class Parent
{
    static Parent()
    {
        Console.WriteLine("Parent Static");
    }

    public Parent()
    {
        Console.WriteLine("Parent Instance");
    }
}

class Child : Parent
{
    static Child()
    {
        Console.WriteLine("Child Static");
    }

    public Child()
    {
        Console.WriteLine("Child Instance");
    }
}

class Program
{
    static void Main()
    {
        Child c1 = new Child();
        Console.WriteLine("-----");
        Child c2 = new Child();
    }
}
