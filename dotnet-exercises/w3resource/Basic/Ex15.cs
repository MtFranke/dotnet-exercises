using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program remove specified a character from a non-empty string using index of a character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
 */
public class Ex15: IRunner
{
    public void Run()
    {
        const string input = "w3resource";
        Console.WriteLine($"{input}, 1 -> {DoAlgorithm(input, 1)}");
        Console.WriteLine($"{input}, 9 -> {DoAlgorithm(input, 9)}");
        Console.WriteLine($"{input}, 0 -> {DoAlgorithm(input, 0)}");
        
    }

    [Pure]
    private static string DoAlgorithm(string input, int indexOf)
    {
        return input.Remove(indexOf, 1);
    }
}