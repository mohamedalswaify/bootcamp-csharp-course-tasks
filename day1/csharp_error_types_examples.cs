// C# Course - Error Types Examples
// Created by Mohamed Alswaify
// This file demonstrates: Type Error, Syntax Error, Runtime Error, and Logic Error

using System;

namespace ErrorExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("1. Type Error Example:");
            Console.WriteLine("=========================");

            // Type Error:
            // This will not compile because it tries to assign a string to an int variable.
            // int number = "123"; // ❌ Type Error: Cannot implicitly convert type 'string' to 'int'
            Console.WriteLine("// int number = \"123\"; --> ❌ Type Error");


            Console.WriteLine("\n=========================");
            Console.WriteLine("2. Syntax Error Example:");
            Console.WriteLine("=========================");

            // Syntax Error:
            // Missing parenthesis will cause a compile-time error.
            // Console.WriteLine("Hello World"; // ❌ Syntax Error: ; instead of )
            Console.WriteLine("// Console.WriteLine(\"Hello World\"; --> ❌ Syntax Error");


            Console.WriteLine("\n=========================");
            Console.WriteLine("3. Runtime Error Example:");
            Console.WriteLine("=========================");

            try
            {
                int x = 10;
                int y = 0;
                int result = x / y; // ❌ Runtime Error: Division by zero
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Runtime Error Caught: " + ex.Message);
            }


            Console.WriteLine("\n=========================");
            Console.WriteLine("4. Logic Error Example:");
            Console.WriteLine("=========================");

            int length = 5;
            int width = 4;
            int area = length + width; // ❌ Logic Error: Should be length * width
            Console.WriteLine("Wrong area (Logic Error): " + area);
            Console.WriteLine("Correct area should be: " + (length * width));
        }
    }
}
