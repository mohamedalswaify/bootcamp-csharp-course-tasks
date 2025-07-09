using System;

class DoWhileLoopExample
{
    static void Main()
    {
        int age;

        do
        {
            Console.Write("Enter a valid age (between 18 and 60): ");
            age = int.Parse(Console.ReadLine());
        }
        while (age < 18 || age > 60);

        Console.WriteLine("Accepted age: " + age);
    }
}
