using System;

namespace FunctionCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

            // Task 1
            double annual = tasks.GetAnnualSalary(12000);
            Console.WriteLine("Annual Salary: " + annual);

            // Task 2
            double percentage = tasks.GetPercentage(45, 60);
            Console.WriteLine("Student Percentage: " + percentage + " %");

            // Task 3
            double bmi = tasks.CalculateBMI(1.75, 85);
            Console.WriteLine("BMI: " + bmi);
        }
    }
}
