using System;

class ModifyElementExample
{
    static void Main()
    {
        int[] scores = { 80, 90, 70 };
        scores[2] = 100;
        Console.WriteLine(scores[2]);
    }
}
