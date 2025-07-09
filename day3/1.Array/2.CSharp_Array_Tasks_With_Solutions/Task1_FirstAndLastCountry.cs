using System;

class Task1_FirstAndLastCountry
{
    static void Main()
    {
        string[] countries = { "Egypt", "Saudi Arabia", "Morocco", "UAE", "Jordan" };
        Console.WriteLine("First country: " + countries[0]);
        Console.WriteLine("Last country: " + countries[countries.Length - 1]);
    }
}
