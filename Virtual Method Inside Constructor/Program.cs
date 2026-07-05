using System;

class Parent
{
    public Parent()
    {
        Show();
    }

    public virtual void Show()
    {
        Console.WriteLine("Parent");
    }
}

class Child : Parent
{
    int x = 100;

    public override void Show()
    {
        Console.WriteLine(x);
    }
}

class Program
{
    static void Main()
    {
        Child c = new Child();
    }
}
