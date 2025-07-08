// C# Tasks with if/else statements
// Created by Mohamed Alswaify

using System;

namespace IfElseTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Task 1: Employee Salary Check");
            Console.WriteLine("=============================");

            Console.Write("Enter your name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter your monthly salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            double annualSalary = salary * 12;

            Console.WriteLine("\nName: " + employeeName);
            Console.WriteLine("Monthly Salary: " + salary);
            Console.WriteLine("Annual Salary: " + annualSalary);

            if (salary >= 10000)
                Console.WriteLine("High Salary");
            else
                Console.WriteLine("Low Salary");


            Console.WriteLine("\n=============================");
            Console.WriteLine("Task 2: Student Result Check");
            Console.WriteLine("=============================");

            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your mark: ");
            double mark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter full mark: ");
            double fullMark = Convert.ToDouble(Console.ReadLine());

            double percentage = (mark / fullMark) * 100;

            Console.WriteLine("\nName: " + studentName);
            Console.WriteLine("Mark: " + mark + " out of " + fullMark);
            Console.WriteLine("Percentage: " + percentage + " %");

            if (percentage >= 50)
                Console.WriteLine("Result: Success");
            else
                Console.WriteLine("Result: Failed");


            Console.WriteLine("\n=============================");
            Console.WriteLine("Task 3: Patient BMI Check");
            Console.WriteLine("=============================");

            Console.Write("Enter your name: ");
            string patientName = Console.ReadLine();

            Console.Write("Enter your height in meters (e.g. 1.75): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("\nName: " + patientName);
            Console.WriteLine("Height: " + height + " m");
            Console.WriteLine("Weight: " + weight + " kg");
            Console.WriteLine("BMI: " + bmi);

            if (bmi >= 25)
                Console.WriteLine("Over Weight");
            else
                Console.WriteLine("Normal Weight");
        }
    }
}
