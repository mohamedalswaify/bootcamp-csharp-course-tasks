// C# Course - Variables, Data Types, Input, and Output
// Created by Mohamed Alswaify

using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("1. Variables and Data Types");
            Console.WriteLine("============================");

            // Variable declaration with different data types
            int age = 27;
            double price = 199.99;
            char grade = 'A';
            bool isRegistered = true;
            string name = "Mohamed";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Registered: " + isRegistered);


            Console.WriteLine("\n=================");
            Console.WriteLine("2. User Input");
            Console.WriteLine("=================");

            // Taking user input from console
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product price: ");
            double userPrice = Convert.ToDouble(Console.ReadLine());

            // Output
            Console.WriteLine("\n=================");
            Console.WriteLine("3. Output Result");
            Console.WriteLine("=================");

            Console.WriteLine("Welcome, " + userName + "!");
            Console.WriteLine("Your age is: " + userAge);
            Console.WriteLine("Entered price is: " + userPrice + " USD");
        }
    }
}
