using System;

class Task4_ReplaceName
{
    static void Main()
    {
        string[] names = { "Ali", "Sara", "Omar" };
        names[1] = "Laila";

        Console.WriteLine("Updated names:");
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
    }
}
