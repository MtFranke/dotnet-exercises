using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
Sample Input:
103
90
89
Expected Output:
True
True
False
*/

public class BAEx4 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{160} -> {DoAlgorithm(160)}");
        Console.WriteLine($"{89} -> {DoAlgorithm(89)}");
        Console.WriteLine($"{103} -> {DoAlgorithm(103)}");
        Console.WriteLine($"{90} -> {DoAlgorithm(90)}");
        Console.WriteLine($"{190} -> {DoAlgorithm(190)}");
        Console.WriteLine($"{205} -> {DoAlgorithm(205)}");
    }

    [Pure]
    private static bool DoAlgorithm(int n)
    {
        const int number1 = 100;
        const int number2 = 200;
        const int acceptableRange = 10;

        if (Math.Abs(n - number1) <= acceptableRange)
            return true;

        if (Math.Abs(n - number2) <= acceptableRange)
            return true;

        return false;
    }
}