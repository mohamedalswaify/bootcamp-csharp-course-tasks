using System;

class WhileLoopExample
{
    static void Main()
    {
        string username = "";

        while (username != "admin")
        {
            Console.Write("Enter username: ");
            username = Console.ReadLine();
        }

        Console.WriteLine("Welcome, admin!");
    }
}
