using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20
*/
public class Ex21 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"10, 20 -> {DoAlgorithm(10, 20)}");
        Console.WriteLine($"10, 10 -> {DoAlgorithm(10, 10)}");
        Console.WriteLine($"5, 5 -> {DoAlgorithm(5, 5)}");
    }

    [Pure]
    private static bool DoAlgorithm(int x,int y)
    {
        const int number = 20;
        return x + y == number || x == number || y == number;
    }
}