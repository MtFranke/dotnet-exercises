using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
Sample Input:
53
30
51
Expected Output:
6
21
0
*/
public class BAEx2 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"Input 53 -> {DoAlgorithm(53)}");
        Console.WriteLine($"Input 30 -> {DoAlgorithm(30)}");
        Console.WriteLine($"Input 51 -> {DoAlgorithm(51)}");
    }

    [Pure]
    private static int DoAlgorithm(int n)
    {
        const int number = 51;
        const int multiplier = 3;

        return n > number ? (n - number) * multiplier : Math.Abs(n - number);
    }
}