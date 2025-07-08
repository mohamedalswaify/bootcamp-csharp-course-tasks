// C# Combined Tasks: Employee, Student, and Patient BMI
// Created by Mohamed Alswaify

using System;

namespace CombinedTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to the Task Center");
            Console.WriteLine("==============================");

            Console.WriteLine("Choose a task to execute:");
            Console.WriteLine("1 - Employee Salary Info");
            Console.WriteLine("2 - Student Percentage Calculator");
            Console.WriteLine("3 - Patient BMI Calculator");
            Console.Write("Enter choice (1-3): ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    RunEmployeeTask();
                    break;
                case "2":
                    RunStudentTask();
                    break;
                case "3":
                    RunPatientTask();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please run the program again.");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void RunEmployeeTask()
        {
            Console.WriteLine("--- Employee Salary Info ---");

            Console.Write("Enter your name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter your monthly salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            double annualSalary = salary * 12;

            Console.WriteLine("\nName: " + employeeName);
            Console.WriteLine("Monthly Salary: " + salary + " SAR");
            Console.WriteLine("Annual Salary: " + annualSalary + " SAR");
        }

        static void RunStudentTask()
        {
            Console.WriteLine("--- Student Percentage Calculator ---");

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
        }

        static void RunPatientTask()
        {
            Console.WriteLine("--- Patient BMI Calculator ---");

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
        }
    }
}
