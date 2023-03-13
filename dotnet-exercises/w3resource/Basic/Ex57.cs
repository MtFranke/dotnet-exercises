using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

//Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.
public class Ex57 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm(new [] { 1, -3, 4, -5, 1})}"); 
        Console.WriteLine($"{DoAlgorithm(new [] { 1, 3, 4, 5, 2 })}"); 
        Console.WriteLine($"{DoAlgorithm(new [] { 1 , 3, -4, 5, 2})}"); 
        Console.WriteLine($"{DoAlgorithm(new [] { 1 , 0, -4, 0, 2})}"); 
    }

    /*[Pure]
    private static int DoAlgorithm(int[] arr)
    {
        var maxProduct = arr[0] * arr[1];
        for (var i = 0; i < arr.Length; i++)
        {
            if (i + 1 >= arr.Length) break;
            var product = arr[i] * arr[i + 1];
            maxProduct = Math.Max(product, maxProduct);
        }

        return maxProduct;
    }*/
    
    [Pure]
    private static int DoAlgorithm(int[] arr)
        => arr
            .Take(arr.Length - 1)
            .Select((value,index) => value * arr[index + 1])
            .Max();

    
}