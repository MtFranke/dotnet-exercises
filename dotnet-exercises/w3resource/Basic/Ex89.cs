using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to count positive and negative numbers in a given array of integers. Go to the editor
Sample Output:
Original Array elements:
10 -11 12 -13 14 -18 19 -20
Number of positive numbers: 4
Number of negative numbers: 4
Original Array elements:
-4 -3 -2 0 3 5 6 2 6
Number of positive numbers: 5
Number of negative numbers: 3
Original Array elements:
Number of positive numbers: 0
Number of negative numbers: 0
*/
public class Ex89 : IRunner
{
    public void Run()
    {
        DoAlgorithm(new[]{10, -11, 12, -13, 14, -18, 19, -20});
        DoAlgorithm(new[]{-4, -3, -2, 0, 3, 5, 6, 2, 6});
        DoAlgorithm(new int[0]);
    }


    private static void DoAlgorithm(IEnumerable<int> numbers)
    {
        Console.WriteLine($"Number of positive numbers: {numbers.Count(x => x > 0)}"); 
        Console.WriteLine($"Number of negative numbers: {numbers.Count(x => x < 0)}"); 
    }
}