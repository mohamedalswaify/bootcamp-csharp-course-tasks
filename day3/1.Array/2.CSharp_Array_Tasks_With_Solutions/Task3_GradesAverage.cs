using System;

class Task3_GradesAverage
{
    static void Main()
    {
        int[] grades = { 90, 80, 85, 95 };
        double average = (grades[0] + grades[1] + grades[2] + grades[3]) / 4.0;
        Console.WriteLine("Average grade: " + average);
    }
}
