using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to remove the first and last elements from a given string.
Sample Output:
Original string: PHP
After removing first and last elements: H
Original string: Python
After removing first and last elements: ytho
Original string: JavaScript
After removing first and last elements: avaScrip
*/
public class Ex70 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("PHP"));
        Console.WriteLine(DoAlgorithm("Python"));
        Console.WriteLine(DoAlgorithm("JavaScript"));
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        return input.Substring(1, input.Length - 2);
    }
}