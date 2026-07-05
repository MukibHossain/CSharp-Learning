using System;

class A
{
    public A(int x)
    {
        Console.WriteLine(x);
    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("B");
    }
}

class Program
{
    static void Main()
    {
        B b = new B();
    }
}
