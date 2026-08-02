

// Create a delegate that can perform addition and subtraction of two numbers.Use the delegate to call both methods.

using System;

namespace DelegateExample
{
    // Declare delegate
    public delegate int MathOperation(int a, int b);

    class Program
    {
        // Method for addition
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method for subtraction
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            // Assign Add method to delegate
            MathOperation operation = Add;
            Console.WriteLine("Addition: " + operation(10, 5));

            // Assign Subtract method to delegate
            operation = Subtract;
            Console.WriteLine("Subtraction: " + operation(10, 5));

            Console.ReadLine();
        }
    }
}
