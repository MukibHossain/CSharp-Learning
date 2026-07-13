//Write a C# Program with a class called Inherit which should have a String type

//variable named str and a member method with the name inheritmethod.

//a) Create a child class of Inherit with the name InheritChild and access

//the str from Inherit class. and it will have its own method called inheritchildmethod

//b) Create a child class of InheritChild with the name Child and from this class

using System;

namespace InheritanceDemo
{

    public class Inherit
    {

        protected string str = "Hello from the base Inherit class!";

        public void inheritmethod()
        {
            Console.WriteLine("Executing: inheritmethod from Inherit class.");
        }
    }


    public class InheritChild : Inherit
    {
        public void inheritchildmethod()
        {

            Console.WriteLine($"Executing: inheritchildmethod. Value of str: '{str}'");
        }
    }


    public class Child : InheritChild
    {
        public void childmethod()
        {

            Console.WriteLine("Executing: childmethod from the final Child class.");

            Console.WriteLine($"Grandchild accessing str: '{str}'");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Inheritance Demonstration ---\n");


            Child myChildInstance = new Child();


            myChildInstance.inheritmethod();


            myChildInstance.inheritchildmethod();


            myChildInstance.childmethod();

            Console.ReadLine();
        }
    }
}
