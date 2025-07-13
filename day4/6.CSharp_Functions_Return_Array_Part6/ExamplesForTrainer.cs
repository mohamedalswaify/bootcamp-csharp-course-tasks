using System;

class EmployeeSummaryExample
{
    static string[] GetEmployeeSummary(string name, double salary)
    {
        double annual = salary * 12;
        string level = salary >= 15000 ? "High" :
                       salary >= 10000 ? "Normal" :
                       salary >= 5000 ? "Low" : "Very Low";

        return new string[]
        {
            "Name: " + name,
            "Monthly Salary: " + salary,
            "Annual Salary: " + annual,
            "Level: " + level
        };
    }

    static void Main()
    {
        string[] summary = GetEmployeeSummary("Ahmed", 12000);
        Console.WriteLine("=== Employee Summary ===");
        foreach (var item in summary)
            Console.WriteLine(item);
    }
}
