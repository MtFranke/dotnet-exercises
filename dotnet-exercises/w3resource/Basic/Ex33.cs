using System;
using System.Diagnostics.Contracts;

/*
Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
Sample Output:
Input first integer:
15
True
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex33 : IRunner
    {
        public void Run()
        {
            Console.Write("Enter integrer: ");
            int.TryParse(Console.ReadLine(), out var n);
            Console.WriteLine($"{DoAlgorithm(n)}");
        }

        [Pure]
        private static bool DoAlgorithm(int n) 
         => n % 3 == 0 || n % 7 == 0;
        
    }
}

