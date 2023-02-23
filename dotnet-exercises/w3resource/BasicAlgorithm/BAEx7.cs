using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
Sample Input:
"abcd"
"a"
"xy"
Expected Output:
dbca
a
yx
*/
public class BAEx7 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"abcd -> {DoAlgorithm("abcd")}");
        Console.WriteLine($"xy -> {DoAlgorithm("xy")}");
        Console.WriteLine($"a -> {DoAlgorithm("a")}");
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        if (input.Length < 2)
            return input;

        var firstLetter = input.Substring(0, 1);
        var lastLetter = input.Substring(input.Length - 1, 1);
        var trimmedStartAndEndLetter = input.Substring(1, input.Length - 2);
        return lastLetter + trimmedStartAndEndLetter + firstLetter;
    }
}