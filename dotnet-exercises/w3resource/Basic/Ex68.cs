using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

//Write a C# Sharp program to count a specified character (both cases) in a given string.
public class Ex68 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("PHP Exercises", 'E', 'e')); 
        Console.WriteLine(DoAlgorithm("Latest News, Breaking News LIVE", 'A', 'a')); 
    }

    [Pure]
    private static int DoAlgorithm(string input, char lowerCase, char upperCase)
    {
        var count = input.Count(c => c == lowerCase || c == upperCase);
        return count;
    }
}