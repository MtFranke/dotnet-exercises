using System;

/*
Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
Test Data:
Array1: [1, 2, 5]
Array2: [0, 3, 8]
Array3: [-1, 0, 2]
New array: [2, 3, 0]  
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex52 : IRunner
    {
        public void Run()
        {
            var array1 = new[] { 1, 2, 5 };
            var array2 = new[] { 0, 3, 8 };
            var array3 = new[] { -1, 0, 2 };

            Console.WriteLine("Test Data: ");
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("[{0}]", string.Join(", ", array3));

            var newArray = new[] { array1[1], array2[1], array3[1] };
            Console.WriteLine("[{0}]", string.Join(", ", newArray));

        }
    }
}

