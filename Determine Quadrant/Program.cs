using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("1st Quadrant");
        else if (x < 0 && y > 0)
            Console.WriteLine("2nd Quadrant");
        else if (x < 0 && y < 0)
            Console.WriteLine("3rd Quadrant");
        else if (x > 0 && y < 0)
            Console.WriteLine("4th Quadrant");
        else
            Console.WriteLine("On Axis");
    }
}
