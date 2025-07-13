using System;

namespace FunctionCalls
{
    public class Tasks
    {
        public string[] GetStudentSummary(string name, double mark, double fullMark)
        {
            double percentage = (mark / fullMark) * 100;
            string grade;

            if (percentage >= 85)
                grade = "Excellent";
            else if (percentage >= 75)
                grade = "Very Good";
            else if (percentage >= 65)
                grade = "Good";
            else if (percentage >= 50)
                grade = "Pass";
            else
                grade = "Failed";

            return new string[]
            {
                "Name: " + name,
                "Mark: " + mark + " / " + fullMark,
                "Percentage: " + percentage + "%",
                "Grade: " + grade
            };
        }

        public string[] GetPatientSummary(string name, double height, double weight)
        {
            double bmi = weight / (height * height);
            string category;

            if (bmi < 18.5)
                category = "Underweight";
            else if (bmi < 25)
                category = "Normal Weight";
            else if (bmi < 30)
                category = "Overweight";
            else
                category = "Obese";

            return new string[]
            {
                "Name: " + name,
                "Height: " + height + " m",
                "Weight: " + weight + " kg",
                "BMI: " + bmi,
                "Category: " + category
            };
        }
    }
}
