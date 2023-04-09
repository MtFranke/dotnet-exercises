using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to remove all vowels from a given string.
Sample Output:
Orginal string: Python
After removing all the vowels from the said string: Pythn
Orginal string: C Sharp
After removing all the vowels from the said string: C Shrp
Orginal string: JavaScript
After removing all the vowels from the said string: JvScrpt
*/
public class Ex83 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("Python"));
        Console.WriteLine(DoAlgorithm("C Sharp"));
        Console.WriteLine(DoAlgorithm("JavaScript"));
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        var regex = new Regex("[AEUIOaeiou]");
        var newInput = regex.Replace(input, String.Empty);
        return newInput;
    }
}