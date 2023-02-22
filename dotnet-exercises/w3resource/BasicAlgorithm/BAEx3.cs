using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.BasicAlgorithm;
/*
Write a C# Sharp program to check two given integers, 
and return true if one of them is 30 or if their sum is 30.
Sample Input:
30, 0
25, 5
20, 30
20, 25
Expected Output:
True
True
True
False
*/
public class BAEx3 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{30}, {0} -> {DoAlgorithm(30, 0)}");
        Console.WriteLine($"{25}, {5} -> {DoAlgorithm(25, 5)}");
        Console.WriteLine($"{20}, {30} -> {DoAlgorithm(20, 30)}");
        Console.WriteLine($"{20}, {25} -> {DoAlgorithm(20, 25)}");
    }

    
    [Pure]
    private static bool DoAlgorithm(int x, int y)
    {
        const int number = 30;
        return x == number || y == number || x + y == number;
    }
}