using System;
/*
Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
Sample Output:
Input a first number(<100): 75
Input a second number(>100): 250
True 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex35 : IRunner
    {
        public void Run()
        {
            Console.Write("Input a first number(<100): ");
            int.TryParse(Console.ReadLine(), out int n1);

            Console.Write("Input a first number(>200): ");
            int.TryParse(Console.ReadLine(), out int n2);

            Console.WriteLine(n1 < 100 && n2 > 200);
        }
    }
}

