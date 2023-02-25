using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
*/
public class Ex19: IRunner
{
    public void Run()
    {
        Console.WriteLine($"2, 2 -> {DoAlgorithm(2,2)}");
        Console.WriteLine($"10, 2 -> {DoAlgorithm(10,2)}");
    }

    [Pure]
    private static int DoAlgorithm(int x, int y)
        => x != y ? x + y : (x + y) * 3;

}