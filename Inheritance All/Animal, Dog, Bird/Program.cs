//Write a C# program with a class called Animal which will have some member

//method as walk and eat.

//a) Create a child class of Animal called Dog with the property nooflegs and bark

//b) Create a child class of Animal called Bird with the property noofwings and fly

//c) Create a child class of Bird called Dove with the property color


using System;

class Animal
{
    public void Walk()
    {
        Console.WriteLine("The animal moves forward by walking.");
    }

    public void Eat()
    {
        Console.WriteLine("The animal is consuming its food.");
    }
}

class Dog : Animal
{
    public int NoOfLegs { get; set; }

    public void Bark()
    {
        Console.WriteLine("The dog is making a barking sound: Woof!");
    }
}

class Bird : Animal
{
    public int NoOfWings { get; set; }

    public void Fly()
    {
        Console.WriteLine("The bird spreads its wings and flies into the sky.");
    }
}

class Dove : Bird
{
    public string Color { get; set; }

    public void Display()
    {
        Console.WriteLine("Appearance: The dove is " + Color + " in color.");
    }
}

class Program
{
    static void Main()
    {

        Dog dog = new Dog();
        dog.NoOfLegs = 4;
        dog.Walk();
        dog.Eat();
        dog.Bark();
        Console.WriteLine("Total legs on this dog: " + dog.NoOfLegs);

        Console.WriteLine();


        Dove dove = new Dove();
        dove.NoOfWings = 2;
        dove.Color = "White";
        dove.Walk();
        dove.Eat();
        dove.Fly();
        dove.Display();
        Console.WriteLine("Total wings on this dove: " + dove.NoOfWings);
    }
}
