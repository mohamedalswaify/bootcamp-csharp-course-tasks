using System;

class WhileLoopTask
{
    static void Main()
    {
        // Example 2: while loop
        // الهدف: طباعة الأرقام من 1 إلى n حسب إدخال المستخدم
        
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        int sum = 0;

        while (i <= n)
        {
            if (i % 2 == 0)
                sum += i;
            i++;
        }

        Console.WriteLine("Sum of even numbers from 1 to " + n + " is: " + sum);
    }
}
