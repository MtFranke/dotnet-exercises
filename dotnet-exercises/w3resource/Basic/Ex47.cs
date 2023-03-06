using System;

/*
Write a C# program to compute the sum of all the elements of an array of integers.
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
Sum: 69 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex47 : IRunner
    {
        public void Run()
        {
            int[] nums = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            var sum = nums.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
