/// Indexer

using System;
public class Car
{
    public string Model { get; set; }
    public string Brand { get; set; }

    public Car(string model, string brand)
    {
        Model = model;
        Brand = brand;
    }
}
public class CarCollection
{
    public Car[] c = new Car[2];
    public Car this[int index]
    {

        set
        {
            if (index >= 0 && index < c.Length)
            {
                c[index] = value;
            }
        }
        get
        {
            if (index >= 0 && index < c.Length)
            {
                return c[index];
            }
            else
            {
                return null;
            }
    }
}
class program
{
    static void Main()
    {
        CarCollection c1 = new CarCollection();
        c1[0] = new Car("X", "Y");
        Console.WriteLine(c1[0].Model);
        Console.WriteLine(c1[0].Brand);

    }
}
}
