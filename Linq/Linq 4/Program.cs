//Delegate for Rectangle Area
//C# Code

using System;

namespace DelegateRectangleArea
{
    class Program
    {
        // Delegate declaration
        public delegate int CalculateRectangleArea(int length, int width);

        // Method matching the delegate signature
        static int GetArea(int length, int width)
        {
            return length * width;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter length of rectangle: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter width of rectangle: ");
            int width = int.Parse(Console.ReadLine());

            // Create a delegate instance pointing to GetArea
            CalculateRectangleArea areaCalculator = GetArea;

            // Invoke the delegate
            int area = areaCalculator(length, width);

            Console.WriteLine($"The area of the rectangle (length = {length}, width = {width}) is: {area}");
        }
    }
}
