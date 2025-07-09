using System;

class Task2_SwapElements
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30 };

        // Swap first and last
        int temp = numbers[0];
        numbers[0] = numbers[2];
        numbers[2] = temp;

        Console.WriteLine("After swap:");
        Console.WriteLine("First: " + numbers[0]);
        Console.WriteLine("Second: " + numbers[1]);
        Console.WriteLine("Third: " + numbers[2]);
    }
}
