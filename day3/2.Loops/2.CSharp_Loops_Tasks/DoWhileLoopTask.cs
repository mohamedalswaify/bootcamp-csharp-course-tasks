using System;

class DoWhileLoopTask
{
    static void Main()
    {



        // Example 3: do-while loop
        // الهدف: تكرار طلب كلمة المرور حتى إدخال كلمة صحيحة
        
        
        
        string password;

        do
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();

        } while (password != "admin123");

        Console.WriteLine("Access granted!");
    }
}
