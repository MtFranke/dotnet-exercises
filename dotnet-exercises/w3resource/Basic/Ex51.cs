using System;

/*
Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
Test Data:
Array1: [1, 2, 5, 7, 8]
Highest value between first and last values of the said array: 8 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex51 : IRunner
    {
        public void Run()
        {
            var nums = new[] { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Highest value between first and last values of the said array: {0}", nums.Max());
        }
    }
}

