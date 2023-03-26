using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

//Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.
public class Ex69 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("AAA"));
        Console.WriteLine(DoAlgorithm("aaa"));
        Console.WriteLine(DoAlgorithm("AaA"));

    }

    [Pure]
    private static bool DoAlgorithm(string input)
        => input == input.ToLower() || input == input.ToUpper();
    
}