using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to remove all characters which are non-letters from a given string.
From Wikipedia,
A letter is a segmental symbol of a phonemic writing system. The inventory of all letters forms the alphabet.
Letters broadly correspond to phonemes in the spoken form of the language, although there is rarely a consistent, exact correspondence between letters and phonemes
Sample Output:
Orginal string: Py@th12on
Remove all characters from the said string which are non-letters: Python
Orginal string: Python 3.0
Remove all characters from the said string which are non-letters: Python
Orginal string: 2^sdfds*^*^jlljdslfnoswje34u230sdfds984
Remove all characters from the said string which are non-letters: sdfdsjlljdslfnoswjeusdfds
*/
public class Ex82 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("Py@th12on"));
        Console.WriteLine(DoAlgorithm("Python 3.0"));
        Console.WriteLine(DoAlgorithm("2^sdfds*^*^jlljdslfnoswje34u230sdfds984"));
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        var regPattern = "[^a-zA-Z]";
        var regex = new Regex(regPattern);
        var replaced = regex.Replace(input, "");
        return replaced;
    }
}