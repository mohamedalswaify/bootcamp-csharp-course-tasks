using System;

class ForeachLoopTask
{
    static void Main()
    {
        // Example 4: foreach loop
        // الهدف: طباعة عناصر مصفوفة أسماء الطلاب
        
        string[] students = { "Ali", "Mona", "Tamer", "Sarah" };

        Console.WriteLine("List of students:");
        foreach (string student in students)
        {
            Console.WriteLine("- " + student);
        }
    }
}
