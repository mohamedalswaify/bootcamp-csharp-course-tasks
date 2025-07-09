using System;

class ForeachLoopExample
{
    static void Main()
    {
        string[] cities = { "Cairo", "Riyadh", "Amman", "Beirut" };

        Console.WriteLine("Cities List:");

        foreach (string city in cities)
        {
            Console.WriteLine("- " + city);
        }
    }
}
