using System;
using System.Drawing;
class rectangle
{
    private double length;
    private double width;
    public double Length
    {
        get { return length; }
        set
        {
            if (value < 0)
                length = 0;
            else
                length = value;
        }
    }
    public double Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                width = 0;
            else
                width = value;
        }
    }
    public double Area()
    {
        return Length * Width;
    }


}
class Program
{
    static void Main()
    {
        rectangle r = new rectangle();

        r.Length = -5;   // negative  so it will be zero
        r.Width = 10;

        Console.WriteLine("Length: " + r.Length);
        Console.WriteLine("Width: " + r.Width);
        Console.WriteLine("Area: " + r.Area());
    }
}
