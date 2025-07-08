// C# Tasks using switch-case
// Created by Mohamed Alswaify

using System;

namespace SwitchCaseTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Select a Task to Run:");
            Console.WriteLine("1 - Day Name by Number");
            Console.WriteLine("2 - Grade Description by Letter");
            Console.WriteLine("3 - Month Days Count");
            Console.Write("Enter your choice (1-3): ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    DayNameByNumber();
                    break;
                case 2:
                    GradeDescriptionByLetter();
                    break;
                case 3:
                    MonthDaysCount();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please run the program again.");
                    break;
            }
        }

        static void DayNameByNumber()
        {
            Console.Write("Enter a number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }

        static void GradeDescriptionByLetter()
        {
            Console.Write("Enter your grade letter (A-F): ");
            string grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Very Good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Pass");
                    break;
                case "F":
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Invalid grade letter.");
                    break;
            }
        }

        static void MonthDaysCount()
        {
            Console.Write("Enter a month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month has 31 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month has 30 days.");
                    break;
                case 2:
                    Console.WriteLine("This month has 28 or 29 days (depending on leap year).");
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }
        }
    }
}
