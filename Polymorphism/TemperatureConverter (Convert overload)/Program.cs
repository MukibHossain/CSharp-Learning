//✅ Compile - Time Polymorphism(Method Overloading)
//2.Create a class TemperatureConverter with multiple 
//overloaded versions of a method Convert().
//Implement the following overloads:
//One that converts Celsius to Fahrenheit.
//One that converts Fahrenheit to Celsius using 
//a boolean parameter to differentiate the method.
//One that converts Celsius to Kelvin.
//Write a program that demonstrates compile-time
//polymorphism by calling each overloaded Convert() method.

using System;
class TemperatureConverter
{
    public double Convert(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double Convert(double fahrenheit, bool isFahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    public double Convert(int celsius)
    {
        return celsius + 273.15;
    }
}

class Program
{
    static void Main()
    {
        TemperatureConverter temp = new TemperatureConverter();

        Console.WriteLine("25°C to Fahrenheit = " + temp.Convert(25.0) + " F");

        Console.WriteLine("77°F to Celsius = " + temp.Convert(77.0, true) + " C");

        Console.WriteLine("25°C to Kelvin = " + temp.Convert(25) + " K");
    }

}
