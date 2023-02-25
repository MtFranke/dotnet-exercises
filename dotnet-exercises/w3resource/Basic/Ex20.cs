using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to get the absolute value of the difference between two given numbers.
Return double the absolute value of the difference if the first number is greater than second number.
*/
public class Ex20 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm(2, 10)}");
        Console.WriteLine($"{DoAlgorithm(12, 10)}");
    }

    [Pure]
    private static int DoAlgorithm(int x, int y)
        => x > y ? Math.Abs(x - y) * 2 : Math.Abs(x - y);
}
