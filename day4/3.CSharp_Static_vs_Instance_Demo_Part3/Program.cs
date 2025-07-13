using System;

namespace StaticVsNonStaticExample
{
    class Calculator
    {
        // Static method: general utility
        public static double StaticAdd(double a, double b)
        {
            return a + b;
        }

        // Non-static method: part of the object
        public double InstanceMultiply(double a, double b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Static Method Call ===");
            double sum = Calculator.StaticAdd(10, 20);
            Console.WriteLine("Sum (Static): " + sum);

            Console.WriteLine("\n=== Instance Method Call ===");
            Calculator calc = new Calculator();
            double product = calc.InstanceMultiply(5, 4);
            Console.WriteLine("Product (Instance): " + product);
        }
    }
}
