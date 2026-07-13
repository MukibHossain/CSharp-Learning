

//Question 1: 1.Write a C# program where input type of the shape output is the area of that shape.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the shape name (circle, rectangle, triangle): ");
            string shapeName = Console.ReadLine().ToLower();
            double area = 0;

            if (shapeName == "circle")
            {
                Console.Write("Enter radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radius * radius;
                Console.WriteLine("The area is: " + area);
            }
            else if (shapeName == "rectangle")
            {
                Console.WriteLine("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                area = length * width;
                Console.WriteLine("The area is: " + area);
            }
            else if (shapeName == "triangle")
            {
                Console.WriteLine("Enter base: ");
                double baseLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * baseLength * height;
                Console.WriteLine("The area is: " + area);
            }
            else
            {
                Console.WriteLine("Invalid shape name.");
            }
        }
    }
}
