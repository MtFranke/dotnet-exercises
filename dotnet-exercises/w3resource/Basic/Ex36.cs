using System;

/*
Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
Sample Output:
Input a first number: -5
Input a second number: 8
True
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex36 : IRunner
    {
        public void Run()
        {
            Console.Write("Input a first number: ");
            int.TryParse(Console.ReadLine(), out int n1);

            Console.Write("Input a first number: ");
            int.TryParse(Console.ReadLine(), out int n2);

            Console.WriteLine(10 > (n1 + n2) && (n1 + n2) > -10);
        }
    }
}

