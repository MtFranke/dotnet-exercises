using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to get the number of letters and digits in a given string.
Sample Output:
Original string:: Python 3.0
Number of letters: 6 Number of digits: 2
Original string:: dsfkaso230samdm2423sa
Number of letters: 14 Number of digits: 7
 */
public class Ex86 : IRunner
{
    public void Run()
    {
        DoAlgorithm("Python 3.0");
        DoAlgorithm("dsfkaso230samdm2423sa");
    }

    private static void DoAlgorithm(string input)
    {
        var letters = input.Count(c => Char.IsLetter(c));
        var digits = input.Count(c => Char.IsDigit(c));

        Console.WriteLine($"Number of letters: {letters} of digits {digits}");
    }
}