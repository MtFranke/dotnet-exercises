using System;
using System.Diagnostics.Contracts;

/*
Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal. Go to the editor
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
Sample Output
True  
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex49 : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{DoAlgorithm()}");
        }

        [Pure]
        private static bool DoAlgorithm()
        {
            var num1 = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            var num2 = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            if (num1[^1] == num2[^1]) return true;
            if (num1[0] == num2[0]) return true;
            
            return false;
        }
    }
}

