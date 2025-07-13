using System;

namespace FunctionCalls
{
    public class Tasks
    {
        public static void Task1_EmployeeSalary()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Task 1: Employee Salary Levels");
            Console.WriteLine("==============================");

            Console.Write("Enter your name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter your monthly salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            double annualSalary = salary * 12;

            Console.WriteLine("\nName: " + employeeName);
            Console.WriteLine("Monthly Salary: " + salary);
            Console.WriteLine("Annual Salary: " + annualSalary);

            if (salary >= 15000)
                Console.WriteLine("High Salary");
            else if (salary >= 10000)
                Console.WriteLine("Normal Salary");
            else if (salary >= 5000)
                Console.WriteLine("Low Salary");
            else
                Console.WriteLine("Very Low Salary");
        }

        public static void Task2_StudentGrading()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("Task 2: Student Grading System");
            Console.WriteLine("==============================");

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

            if (percentage >= 85)
                Console.WriteLine("Grade: Excellent");
            else if (percentage >= 75)
                Console.WriteLine("Grade: Very Good");
            else if (percentage >= 65)
                Console.WriteLine("Grade: Good");
            else if (percentage >= 50)
                Console.WriteLine("Grade: Pass");
            else
                Console.WriteLine("Grade: Failed");
        }

        public static void Task3_PatientBMI()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("Task 3: Patient BMI Category");
            Console.WriteLine("==============================");

            Console.Write("Enter your name: ");
            string patientName = Console.ReadLine();

            Console.Write("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("\nName: " + patientName);
            Console.WriteLine("Height: " + height + " m");
            Console.WriteLine("Weight: " + weight + " kg");
            Console.WriteLine("BMI: " + bmi);

            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal Weight");
            else if (bmi < 30)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");
        }
    }
}
