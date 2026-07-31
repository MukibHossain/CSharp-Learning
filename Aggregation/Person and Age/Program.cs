using System;

class Address
{
    public string Street;
    public string City;

    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }
}

class Person
{
    public string Name;

    public Address Address;

    public Person(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Street: " + Address.Street);
        Console.WriteLine("City: " + Address.City);
    }
}

class Program
{
    static void Main()
    {
        Address a = new Address("Uttara", "Dhaka");

        Person p = new Person("Hasan", a);

        p.Display();
    }
}