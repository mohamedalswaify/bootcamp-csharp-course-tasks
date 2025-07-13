using System;

namespace FunctionCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            // إنشاء كائن من الكلاس Tasks
            Tasks tasks = new Tasks();

            // ================================================================
            // ✅ الطريقة الأولى: استدعاء الدوال باستخدام قيم ثابتة (Hardcoded)
            // ================================================================
            Console.WriteLine("=== Calling Tasks with Hardcoded Values ===");

            tasks.Task1_EmployeeSalary("Ahmed", 12000);                // Task 1
            tasks.Task2_StudentGrading("Sara", 45, 60);                // Task 2
            tasks.Task3_PatientBMI("Omar", 1.75, 85);                  // Task 3

            // فاصل لتمييز بين الطريقتين
            Console.WriteLine("\n===============================================================================\n");

            // ================================================================
            // ✅ الطريقة الثانية: استدعاء الدوال باستخدام إدخال من المستخدم
            // ================================================================
            Console.WriteLine("=== Calling Tasks with User Input ===");

            // Task 1: Employee Salary
            Console.WriteLine("→ Task 1: Employee Salary");
            Console.Write("Enter employee name: ");
            string empName = Console.ReadLine();
            Console.Write("Enter monthly salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            tasks.Task1_EmployeeSalary(empName, salary);

            // Task 2: Student Grading
            Console.WriteLine("\n→ Task 2: Student Grading");
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter student mark: ");
            double mark = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter full mark: ");
            double fullMark = Convert.ToDouble(Console.ReadLine());
            tasks.Task2_StudentGrading(studentName, mark, fullMark);

            // Task 3: Patient BMI
            Console.WriteLine("\n→ Task 3: Patient BMI");
            Console.Write("Enter patient name: ");
            string patientName = Console.ReadLine();
            Console.Write("Enter height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            tasks.Task3_PatientBMI(patientName, height, weight);
        }
    }
}
