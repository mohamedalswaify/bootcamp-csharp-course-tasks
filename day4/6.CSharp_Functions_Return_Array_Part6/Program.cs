using System;

namespace FunctionCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

            // Task 1: Student Grade
            string[] studentResult = tasks.GetStudentSummary("Sara", 45, 60);
            Console.WriteLine("=== Student Summary ===");
            foreach (var item in studentResult)
                Console.WriteLine(item);

            Console.WriteLine();

            // Task 2: Patient BMI
            string[] patientResult = tasks.GetPatientSummary("Omar", 1.75, 85);
            Console.WriteLine("=== Patient Summary ===");
            foreach (var item in patientResult)
                Console.WriteLine(item);
        }
    }
}
