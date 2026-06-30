//Define two interfaces: IAthlete and IMusician.IAthlete should have a method PlaySport() and
//IMusician should have a method PlayInstrument(). Then create a class Person that
//implements both interfaces. Write a program that demonstrates multiple inheritance using
//interfaces by creating a Person object that can play a sport and an instrument.

using System;

// First interface
interface IAthlete
{
    void PlaySport();
}

// Second interface
interface IMusician
{
    void PlayInstrument();
}

// Person class implements both interfaces
class Person : IAthlete, IMusician
{
    public void PlaySport()
    {
        Console.WriteLine("Person is playing football");
    }

    public void PlayInstrument()
    {
        Console.WriteLine("Person is playing guitar");
    }
}

class Program
{
    static void Main()
    {
        // Creating Person object
        Person p = new Person();

        // Calling methods
        p.PlaySport();
        p.PlayInstrument();
    }
}
