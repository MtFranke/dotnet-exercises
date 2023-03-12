using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to check if a given string is a palindrome or not. Go to the editor
Sample Example:
For 'aaa' the output should be true
For 'abcd' the output should be false
*/
public class Ex56 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"'aaa' -> {DoAlgorithm("aaa")}");
        Console.WriteLine($"'abcd' -> {DoAlgorithm("abcd")}");
    }

    [Pure]
    private static bool DoAlgorithm(string input)
        => input == string.Join(string.Empty, input.Reverse());

}