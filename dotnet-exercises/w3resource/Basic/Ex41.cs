using System.Diagnostics.Contracts;


/*
Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
Input a string (contains at least one 'w' char) : w3resource
Test the string contains 'w' character between 1 and 3 times:
Sample Output
True 
*/
namespace dotnet_exercises.w3resource.Basic;

public class Ex41: IRunner
{
    public void Run()
    {
        const string input = "w3resource";
        Console.WriteLine($"{DoAlgorithm(input)}");
    }

    [Pure]
    private static bool DoAlgorithm(string input)
    {
        const char seekedChar = 'w';
        var occurrences = input.Count(x => x == seekedChar);
        return occurrences is >= 1 and <= 3;
    }
}