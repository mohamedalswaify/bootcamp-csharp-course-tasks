using System;

class ExamplesForTrainer
{
    // ✅ Example 1: Using return
    static int MultiplyReturn(int a, int b)
    {
        return a * b;
    }

    // ✅ Example 2: Using void
    static void MultiplyAndDisplay(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Multiplication Result: " + result);
    }

    static void Main()
    {
        // Using return
        int result = MultiplyReturn(5, 6);
        Console.WriteLine("Returned Result: " + result);

        // Using void
        MultiplyAndDisplay(5, 6);
    }
}
