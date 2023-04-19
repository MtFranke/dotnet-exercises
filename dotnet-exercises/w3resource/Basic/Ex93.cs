using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to calculate the square root of a given number.
Do not use any built-in-function, return integer part of the result.
Sample Data:
(120) -> 10
(225) -> 15
(335) -> 18
*/
public class Ex93 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"(120) -> {DoAlgorithm(120)}");
        Console.WriteLine($"(225) -> {DoAlgorithm(225)}");
        Console.WriteLine($"(335) -> {DoAlgorithm(335)}");
    }

    [Pure]
    private static int DoAlgorithm(int number)
    {
        var i = 0;
        while (i * i <= number)
        {
            i++;
        }

        return i - 1;
    }
}