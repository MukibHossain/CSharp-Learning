//Create three classes: Animal, Mammal, and Dog. 
//    The Animal class should have a method Eat(). 
//    The Mammal class should inherit from Animal 
//    and have an additional method Walk(). 
//    The Dog class should inherit from Mammal and have a method Bark()
//    . Write a program to demonstrate multilevel 
//    inheritance by creating a Dog object and calling all the inherited methods.

using System;

class Animal
{
    // Method of Animal class
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Mammal : Animal
{
    // Method of Mammal class
    public void Walk()
    {
        Console.WriteLine("Mammal is walking");
    }
}

class Dog : Mammal
{
    // Method of Dog class
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        // Creating Dog object
        Dog d = new Dog();

        // Calling all inherited methods
        d.Eat();
        d.Walk();
        d.Bark();
    }
}