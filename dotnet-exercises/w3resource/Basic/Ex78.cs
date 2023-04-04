using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to find sum of squares of elements of a given array of integers.
Sample Output:
Sum of squares of elements of the said array: 14
Sum of squares of elements of the said array: 29
*/
public class Ex78 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(new []{1,2,3}));
        Console.WriteLine(DoAlgorithm(new []{-2, 0, 3, 4}));
    }

    [Pure]
    private static int DoAlgorithm(int[] arr)
     => arr.Sum(x => (int)Math.Pow(x, 2));
    
    
}