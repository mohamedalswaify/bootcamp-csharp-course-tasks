// C# Course Tasks - Input and Output Practice
// Created by Mohamed Alswaify

using System;

namespace BeginnerTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Employee Salary
            Console.WriteLine("===============================");
            Console.WriteLine("Task 1: Employee Salary Info");
            Console.WriteLine("===============================");

            Console.Write("Enter your name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter your monthly salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            double annualSalary = salary * 12;

            Console.WriteLine("\n--- Employee Info ---");
            Console.WriteLine("Name: " + employeeName);
            Console.WriteLine("Monthly Salary: " + salary + " SAR");
            Console.WriteLine("Annual Salary: " + annualSalary + " SAR");


            // Task 2: Student Percentage
            Console.WriteLine("\n===============================");
            Console.WriteLine("Task 2: Student Percentage");
            Console.WriteLine("===============================");

            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your mark: ");
            double mark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter full mark: ");
            double fullMark = Convert.ToDouble(Console.ReadLine());

            double percentage = (mark / fullMark) * 100;

            Console.WriteLine("\n--- Student Info ---");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Mark: " + mark + " out of " + fullMark);
            Console.WriteLine("Percentage: " + percentage + " %");


            // Task 3: Patient BMI
            Console.WriteLine("\n===============================");
            Console.WriteLine("Task 3: Patient BMI Info");
            Console.WriteLine("===============================");

            Console.Write("Enter your name: ");
            string patientName = Console.ReadLine();

            Console.Write("Enter your height in meters (e.g. 1.75): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("\n--- Patient Info ---");
            Console.WriteLine("Name: " + patientName);
            Console.WriteLine("Height: " + height + " m");
            Console.WriteLine("Weight: " + weight + " kg");
            Console.WriteLine("BMI: " + bmi);
        }
    }
}
