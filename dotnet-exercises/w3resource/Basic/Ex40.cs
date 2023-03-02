using System;

/*
Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
Test Data:
Input first integer:
15
Input second integer:
12
Sample Output
15
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex40 : IRunner
    {
        public void Run()
        {
            const int n = 20;
            int answer = 0;
            Console.Write("Input first integer: ");
            int.TryParse(Console.ReadLine(), out var a);

            Console.Write("Input second integer: ");
            int.TryParse(Console.ReadLine(), out var b);

            if (n - a < n - b)
            {
                answer = a;
            }
            else {

                answer = b;
            }
          

            Console.WriteLine($"{answer}");
        }
    }
}

