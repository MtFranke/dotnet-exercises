using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not.
Sample Output:
nums = { 1, 2, 3, 5, 4, 2, 3, 4 }
Check the average value of the said array is a whole number or not: True
nums1 = { 2, 4, 2, 6, 4, 8 }
Check the average value of the said array is a whole number or not: False
*/
public class Ex72 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm(new[]{ 1, 2, 3, 5, 4, 2, 3, 4 })}");
        Console.WriteLine($"{DoAlgorithm(new[]{ 2, 4, 2, 6, 4, 8 })}");
    }

    [Pure]
    private static bool DoAlgorithm(int[] arr)
        => arr.Average() % 1 == 0;

    // [Pure]
    // private static bool DoAlgorithm(int[] arr)
    // {
    //
    //     var avg = arr.Average();
    //     var rounded = Math.Round(avg);
    //     return avg == rounded;
    // }

}