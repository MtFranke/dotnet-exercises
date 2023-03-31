using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to check the length of a given string is odd or even.
Return 'Odd length' if the string length is odd otherwise 'Even length'.
Sample Output:
Original string: PHP
Convert the letters of the said string into alphabetical order: Odd length
Original string: javascript
Convert the letters of the said string into alphabetical order: Even length
Original string: python
Convert the letters of the said string into alphabetical order: Even length
 */
public class Ex74 : IRunner
{
    public void Run()
    {
        const string displayText = "Convert the letters of the said string into alphabetical order:";
        Console.WriteLine($"{displayText} {DoAlgorithm("PHP")}");
        Console.WriteLine($"{displayText} {DoAlgorithm("javascript")}");
        Console.WriteLine($"{displayText} {DoAlgorithm("python")}");
    }

    [Pure]
    private static string DoAlgorithm(string input)
        => input.Length % 2 == 0 ? "Even length" : "Odd lenght";
    
}