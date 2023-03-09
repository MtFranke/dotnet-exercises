using System;

/*
Write a C# program to check if an array contains an odd number.
Test Data:
Original array: [2, 4, 7, 8, 6]
Check if an array contains an odd number? True 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex53 : IRunner
    {
        public void Run()
        {
            var nums = new[] { 2, 4, 7, 8, 6 };
            Console.WriteLine("[{0}]", string.Join(", ", nums));
            var oddValues = nums.Any(IsOdd);
            Console.WriteLine(oddValues);
        }

        Func<int, bool> IsOdd => (x) => x % 2 == 1;
    }
}

