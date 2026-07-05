using System;

class X
{
    public X()
    {
        Console.WriteLine("X()");
    }

    public X(int a)
    {
        Console.WriteLine("X(int)");
    }
}

class Y : X
{
    public Y() : this(10)
    {
        Console.WriteLine("Y()");
    }

    public Y(int a) : base(a)
    {
        Console.WriteLine("Y(int)");
    }
}

class Z : Y
{
    public Z() : base()
    {
        Console.WriteLine("Z()");
    }
}

class Program
{
    static void Main()
    {
        Z obj = new Z();
    }
}
