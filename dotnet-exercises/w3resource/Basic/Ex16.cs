using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to create a new string from a given string where the first and last characters will change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP 
*/
public class Ex16 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"Python -> {DoAlgorithm("Python")}");
        Console.WriteLine($"w3resource -> {DoAlgorithm("w3resource")}");
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        var trim = input.Substring(1, input.Length - 1);
        return $"{input.Last()}{trim}{input[0]}";
    }
}