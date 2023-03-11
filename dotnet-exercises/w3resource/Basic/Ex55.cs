using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

//Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value.
public class Ex55 : IRunner
{
    public void Run()
    {
      Console.WriteLine($"{DoAlgorithm(new []{2, 4, 2, 6, 9, 3}, 27)}");  
      Console.WriteLine($"{DoAlgorithm(new []{ 6, 1, 12, 3, 1, 4 }, 36)}");  
    }

    [Pure]
    private static bool DoAlgorithm(int[] arr, int target)
    {
        int maxProduct = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var product = arr[i] * arr[i + 1];
            maxProduct = product > maxProduct ? product : maxProduct;
            if (i + 2 >= arr.Length) break;
        }

        return maxProduct == target;
    }
}