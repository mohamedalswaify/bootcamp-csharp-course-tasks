using System;

namespace FunctionCalls
{
    public class Tasks
    {
        public double GetAnnualSalary(double monthlySalary)
        {
            return monthlySalary * 12;
        }

        public double GetPercentage(double mark, double fullMark)
        {
            return (mark / fullMark) * 100;
        }

        public double CalculateBMI(double height, double weight)
        {
            return weight / (height * height);
        }
    }
}
