using System;

class A
{
    public A()
    {
        Console.WriteLine("A()");
    }

    public A(int x)
    {
        Console.WriteLine("A(int)");
    }
}

class B : A
{
    public B() : this(5)
    {
        Console.WriteLine("B()");
    }

    public B(int x) : base(x)
    {
        Console.WriteLine("B(int)");
    }
}

class C : B
{
    public C() : base()
    {
        Console.WriteLine("C()");
    }
}

class Program
{
    static void Main()
    {
        new C();
    }
}
