using System;

/*
Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
True 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex48 : IRunner
    {
        public void Run()
        {
            const int searchedValue = 1;
            int[] nums = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            var valueExist = false;

            if (nums[0] == searchedValue && nums[^1] == searchedValue) {
                valueExist = true;
            }

            Console.WriteLine(valueExist);

        }
    }
}
