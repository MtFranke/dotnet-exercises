using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to find the longest word in a string. Go to the editor
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following
*/
public class Ex24 : IRunner
{
    public void Run()
    {
        const string input = "Write a C# Sharp Program to display the following pattern using the alphabet.";
        Console.WriteLine($"{DoAlgorithm(input)}");

    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        var pattern = new Regex("[;,.,]|[\n]{2}");
        var inputWithNoSigns = pattern.Replace(input, "");
        
        var split = inputWithNoSigns.Split(" ");
        var words = split.OrderByDescending(x => x.Length)
            .ToArray();

        return words[0];
    }
}